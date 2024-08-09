const express  = require("express")
const mongoose = require("mongoose")
const app      = express()

app.use(express.urlencoded())
app.use(express.json())

const connectionString = "mongodb+srv://camcstocks:H1b3dZ1RVapmC3fB@dotnettestcluster.1fety.mongodb.net/dotnetdb?retryWrites=true&w=majority&appName=DotNetTestCluster"

mongoose.connect(connectionString)
.then(() => console.log("Connected To Mongo"))
.catch(() => console.log("Fucked Up homie"))


const User = require("./modules/user")

app.get("/", (req, res) => {
    res.send("Hello World!")
})

app.post('/add-user', (req, res) => {
    const n = req.body.name;
    const s = req.body.surname;
    const a = req.body.age
    console.log(`Name: ${n}, Surname: ${s}, Age: ${a}`);

    let user = User({
        name: n, 
        surname: s, 
        age: Number(a)
    })

    user.save()
    .then(() => {
        res.status(200).json({
            code: 200,
            message: "User Successfully Added"
        });
    })
    .catch(err => {
        res.status(500).json({
            code: 500,
            message: "User either already exists"
        })
        
    }) 

});

app.post("/get-one", async (req, res) => {
    try {
        const crit = req.body.criteria;
        const search = req.body.search;

        console.log(`Criteria: ${crit} | Search ${search}`);
        

        let user;
        let newUser;

        if (crit === "Name") {
            user = await User.findOne({ name: search });
        } else if (crit === "Surname") {
            user = await User.findOne({ surname: search });
        } else {
            user = await User.findOne({ age: Number(search) });
        }

        if (user) {
            newUser = {
                name: user.name,
                surname: user.surname,
                age: user.age
            };
            res.status(200).json({
                code: 200,
                newUser,
                Message: "User Found Successfully"
            });
        } else {
            res.status(404).json({
                code: 404,
                newUser: [],
                Message: "User not found"
            });
        }
    } catch (err) {
        res.status(500).json({
            code: 500,
            newUser: [],
            Message: "Internal Server Error"
        });
    }
});

app.post("/get-many", async (req, res) => {
    try {

        const age = parseInt(req.body.age)        
        
        const users = await User.find({age: age}).lean()

        if (!users || users.length === 0) {
            res.status(201).json({
                code: 201,
                users: [], 
                Message: "No Users with Specified Age"
            })
            return
        }
        
        res.status(200).json({
            code: 200,
            users, 
            Message: `All Users with age ${age} returned`
        });

    } catch (err) {
        res.status(500).json({
            code: 500,
            users: [], 
            Message: "Internal Server Error"
        })
    }
})


app.delete("/delete-one/:id", async (req, res) => {
    try {
        const result = await User.deleteOne({_id: req.params.id})
        console.log(result);
        
        res.status(200).json({
            Code: 200,
            Message: `User Deleted`
        })
    } catch (err) {
        res.status(400).json({
            code: 400,
            Message: "Internal Server Error"
        })
    }
})

module.exports = app