from flask import Flask 
app = Flask(__name__)
app.secret_key = "bababooey"
DATABASE = "party_db"