const express = require('express');
const bodyParser = require('body-parser');
const sql = require('mssql');
const cors = require('cors');

const app = express();
const PORT = 3000;

app.use(cors());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

const config = {
    server: 'localhost',
    database: 'MealSignupDB',
    user: 'AdminWeb',
    password: '123456789m',
    options: {
      trustServerCertificate: true,
    },
  };
  

let pool;

async function startServer() {
  try {
    pool = await sql.connect(config);
    console.log('Connected to SQL Server');

    app.listen(PORT, () => {
      console.log(`Server running on http://localhost:${PORT}`);
    });
  } catch (err) {
    console.error('SQL connection error:', err);
  }
}

startServer();

app.post('/submit', async (req, res) => {
    console.log('Received POST /submit:', req.body);
  
    const { FullName, Email, Source } = req.body;
  
    if (!FullName || !Email || !Source) {
      return res.status(400).send('Missing required fields');
    }
  
    try {
      const request = pool.request();
      request.input('FullName', sql.NVarChar(100), FullName);
      request.input('Email', sql.NVarChar(100), Email);
      request.input('Source', sql.NVarChar(100), Source);
  
      const result = await request.query(`
        INSERT INTO Signups (FullName, Email, Source)
        VALUES (@FullName, @Email, @Source)
      `);
  
      console.log('Insert result:', result);
      res.status(200).send('Form data saved successfully!');
    } catch (err) {
      console.error('DB error:', err); // ⬅️ Обов’язково дивись сюди в терміналі
      res.status(500).send('Error saving form data');
    }
  });