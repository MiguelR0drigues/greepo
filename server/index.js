const mysql = require('mysql2');
const express = require('express');
const app = express();

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


// Get every project
app.get('/projects', (req, res) => {
    // make the SELECT query
    const sql = 'SELECT * FROM `projects`';
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

// Start the server
app.listen(2080, () => {
    console.log('Server is listening on port 2080');
});

