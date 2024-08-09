const https = require("https")
const fs    = require("fs")

const app = require("./app")


const server = https.createServer({
        key: fs.readFileSync("keys/privatekey.pem"),
        cert: fs.readFileSync("keys/certificate.pem")
    }, app);

server.listen(3050)