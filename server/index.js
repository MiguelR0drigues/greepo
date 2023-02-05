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
app.get('/municipality', (req, res) => {
    // make the SELECT query
    const sql = 'SELECT * FROM `municipality` ORDER BY `id_municipality`';
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});
app.get('/municipalityProject/:id', (req, res) => {
    // make the SELECT query
    const id = mysql.escape(req.params.id);
    const sql = `SELECT projects.id_project, municipality.name AS municipality_name,projects.name AS project_name,projects.description AS project_description FROM municipality INNER JOIN projects ON municipality.id_municipality = projects.id_municipality WHERE municipality.id_municipality = ${id};`
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});
app.get('/regioes/:id', (req, res) => {
    // make the SELECT query
    const id = mysql.escape(req.params.id);
    const sql = `SELECT projects.id_project, municipality.name AS municipality_name,projects.name AS project_name,projects.description AS project_description, regioes.name AS region_name FROM municipality JOIN projects ON municipality.id_municipality = projects.id_municipality JOIN regioes ON municipality.regiao = regioes.id WHERE regioes.id = ${id};`
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});
app.get('/distritos', (req, res) => {
    // make the SELECT query
    const sql = 'SELECT * FROM `distritos` ORDER BY `id`';
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});
app.get('/distritos/:id', (req, res) => {
    // make the SELECT query
    const id = mysql.escape(req.params.id);
    const sql = `SELECT distritos.name AS district_name,projects.name AS project_name,projects.id_project As id_project,projects.description AS project_description FROM municipality JOIN distritos ON municipality.distrito = distritos.id JOIN projects ON municipality.id_municipality = projects.id_municipality JOIN regioes ON municipality.regiao = regioes.id WHERE distritos.id = ${id} ;`
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

    // get the project id from the request parameters and escape it
    const id = mysql.escape(req.params.id);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT * FROM projects WHERE id_project = ${id}`;
    connection.query(sql, (err, results) => {
    if (err) throw err;

    // do something with the results
    res.send(results);
  });
});

// Get project values
app.get('/projects-values/', (req, res) => {

    // get the user id from the request parameters and escape it
    const id = mysql.escape(req.params.id);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT * FROM projects_values WHERE o1 is not null or o2 is not null`;
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});

// Get project ID and values for every project in a certain municipality
app.get('/projectIdandValues/:municipality', (req, res) => {

    // get the project id from the request parameters and escape it
    const municipality = mysql.escape(req.params.municipality);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT projects.id_project, projects_values.o1, projects_values.o2, projects_values.o3, projects_values.o4, projects_values.o5, projects_values.o6, projects_values.o7, projects_values.o8, projects_values.o9, projects_values.o10, projects_values.o11, projects_values.o12, projects_values.o13, projects_values.o14, projects_values.o15, projects_values.o16, projects_values.o17 FROM projects JOIN projects_values ON projects.id_project = projects_values.id_projects JOIN municipality ON projects.id_municipality = municipality.id_municipality WHERE municipality.id_municipality = ${municipality};`;
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});

// Get project ID and values for every project in a certain district
app.get('/project-values-district/:districtId', (req, res) => {

    // get the project id from the request parameters and escape it
    const districtId = mysql.escape(req.params.districtId);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT projects.id_project, projects_values.o1, projects_values.o2, projects_values.o3, projects_values.o4, projects_values.o5, projects_values.o6, projects_values.o7, projects_values.o8, projects_values.o9, projects_values.o10, projects_values.o11, projects_values.o12, projects_values.o13, projects_values.o14, projects_values.o15, projects_values.o16, projects_values.o17 FROM projects JOIN projects_values ON projects.id_project = projects_values.id_projects JOIN municipality ON projects.id_municipality = municipality.id_municipality JOIN distritos on municipality.distrito = distritos.id WHERE distritos.id = ${districtId};`;
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});

// Get project ID and values for every project in a certain region
app.get('/project-values-district/:regiaoId', (req, res) => {

    // get the project id from the request parameters and escape it
    const regiaoId = mysql.escape(req.params.regiaoId);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT projects.id_project, projects_values.o1, projects_values.o2, projects_values.o3, projects_values.o4, projects_values.o5, projects_values.o6, projects_values.o7, projects_values.o8, projects_values.o9, projects_values.o10, projects_values.o11, projects_values.o12, projects_values.o13, projects_values.o14, projects_values.o15, projects_values.o16, projects_values.o17 FROM projects JOIN projects_values ON projects.id_project = projects_values.id_projects JOIN municipality ON projects.id_municipality = municipality.id_municipality JOIN regioes on municipality.regiao = regioes.id WHERE regioes.id = ${regiaoId};`;
    connection.query(sql, (err, results) => {
        if (err) throw err;

        // do something with the results
        res.send(results);
    });
});

// Get project values by id
app.get('/projects-values/:id', (req, res) => {

    // get the project id from the request parameters and escape it
    const id = mysql.escape(req.params.id);

    // make the SELECT query, using the id in the WHERE clause
    const sql = `SELECT * FROM projects_values WHERE id_projects = ${id}`;
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
        connection.query('INSERT INTO `users`(`name`, `email`, `password`,`gender`,`token`,`active`) VALUES (?,?,?,?,0,0)', [name,email, password, gender], function (error, results, fields) {
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

app.get('/send-token/:mail/:token', function (request, response) {
    let mail = request.params.mail;
    let token = request.params.token;
    connection.query('UPDATE `users` SET `token`=? WHERE `email` = ? ', [token,mail], function (error, results, fields) {
        if (error) throw error;

        // do something with the results
        response.send(results);
    });
});

app.post('/get-token', function (request, response) {
    let mail = request.body.mail;
    let token = request.body.token;
    connection.query('UPDATE users SET active=1 WHERE email = ? AND token = ? ', [mail, token], function (error, results, fields) {
        if (error) throw error;

        // do something with the results
        response.send(results);
    });
});

app.get('/user-exist/:email', async (req, res) => {
    const email = req.params.email;
    const userExists = await doesUserExist(email);
    if (userExists) {
        res.status(404).send("Exist")
    }
    else {
        res.status(200).send("Doesn't exist")
    }
});


function doesUserExist(email) {
    return new Promise((resolve, reject) => {
        connection.query('SELECT * FROM users WHERE email = ? ', [email], function (error, results, fields) {
            // If there is an issue with the query, reject the Promise with the error
            if (error) return reject(error);
            // If user already exists
            if (results.length > 0) {
                // Resolve the Promise with `true`
                resolve(true);
            } else {
                // Resolve the Promise with `false`
                resolve(false);
            }
        });
    });
}



// Start the server
app.listen(2080, () => {
    console.log('Server is listening on port 2080');
});

