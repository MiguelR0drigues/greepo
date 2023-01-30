const mysql = require('mysql2');
const express = require('express');
const app = express();
const bodyParser = require('body-parser');
app.use(bodyParser.json());

const connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'greepo'
});

connection.connect((err) => {
    if (err) {
        console.error('Error connecting to database: ' + err.stack);
        return;
    }

    console.log('Connected to database as id ' + connection.threadId);
});


// General route
app.get('/', (req, res) => {
    res.send('You should not be here, please leave now!');
});
app.get('/regioes', (req, res) => {
    // make the SELECT query
    const sql = 'SELECT * FROM `regioes` ORDER BY `id`';
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});
app.get('/regioes/:id', (req, res) => {
    // make the SELECT query
    const id = mysql.escape(req.params.id);
    const sql = `SELECT municipality.name AS municipality_name,projects.name AS project_name,projects.description AS project_description, regioes.name AS region_name FROM municipality JOIN projects ON municipality.id_municipality = projects.id_municipality JOIN regioes ON municipality.regiao = regioes.id WHERE regioes.id = ${id};`
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});
// Get every project
app.get('/projects', (req, res) => {
    // make the SELECT query
    const sql = 'SELECT * FROM `projects` ORDER BY `id_municipality`';
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});


// Get project by id
app.get('/projects/:id', (req, res) => {

    // get the user id from the request parameters and escape it
    const id = mysql.escape(req.params.id);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT * FROM projects WHERE id_project = ${id}`;
    connection.query(sql, (err, results) => {
    if (err) throw err;

    // do something with the results
    res.send(results);
  });
});

// Get project by id
app.get('/municipality/:id', (req, res) => {

    // get the user id from the request parameters and escape it
    const id = mysql.escape(req.params.id);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT name FROM municipality WHERE id_municipality = ${id} LIMIT 1`;
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results[0]);
    });
});

// Get every user
app.get('/users', (req, res) => {
    // make the SELECT query
    const sql = 'SELECT * FROM `users`';
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);

        // end the database connection
        connection.end((err) => {
            if (err) throw err;
        });
    });
});

// Get user by id
app.get('/projects/:id', (req, res) => {

    // get the user id from the request parameters and escape it
    const id = mysql.escape(req.params.id);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT * FROM users WHERE id_user = ${id}`;
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});

/*
app.get('/updateMunicipality', (req, res) => {
    selectProjects(connection);    
});


 * function selectProjects(con) {
    var municipalities = [];

    // make the SELECT query
    const sql = 'SELECT DISTINCT municipality FROM `projects`';
    con.query(sql, (err, results) => {
        if (err) throw err;

        for (let i = 0; i < results.length; i++) {
            municipalities.push(results[i].municipality);
        }
        
        for (let i = 0; i < municipalities.length; i++) {
            const stmt = 'INSERT INTO municipality (name) VALUES (?)';
            con.query(stmt, [municipalities[i]]);
            console.log(i + 'lines inserted');
        }
    });
}
*/

app.post('/login', function (request, response) {
    // Capture the input fields
    let email = request.body.email;
    let password = request.body.password;
    // Ensure the input fields exists and are not empty
    if (email && password) {
        // Execute SQL query that'll select the account from the database based on the specified username and password
        connection.query('SELECT * FROM users WHERE email = ? AND password = ?', [email, password], function (error, results, fields) {
            // If there is an issue with the query, output the error
            if (error) throw error;
            // If the account exists
            if (results.length > 0) {
                // Redirect to home page
                response.send(true);
            } else {
                response.send(false);
            }
            response.end();
        });
    } else {
        response.send(false);
        response.end();
    }
});

app.post('/signup', function (request, response) {
    // Capture the input fields
    let name = request.body.name;
    let gender = request.body.gender;
    let email = request.body.email;
    let password = request.body.password;
    // Ensure the input fields exists and are not empty
    if (email && password && name && gender) {

        //Check if there is an account with that email already
        doesUserExist(email) && response.send(false);

        // Execute SQL query that'll select the account from the database based on the specified username and password
        connection.query('INSERT INTO `users`(`name`, `email`, `password`,`gender`) VALUES (?,?,?,?)', [name,email, password, gender], function (error, results, fields) {
            // If there is an issue with the query, output the error
            if (error) throw error;
            response.send(true);
            response.end();
        });
    } else {
        response.send(false);
        response.end();
    }
});

function doesUserExist(email)
{
    connection.query('SELECT * FROM users WHERE email = ? ', [email], function (error, results, fields) {
        // If there is an issue with the query, output the error
        if (error) throw error;
        // If user already exists
        if (results.length > 0) {
            // Redirect to home page
            return true;
        } else {
            return false;
        }
    });
}


// Start the server
app.listen(2080, () => {
    console.log('Server is listening on port 2080');
});

