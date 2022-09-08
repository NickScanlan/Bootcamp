from flask import Flask, render_template, session, request, redirect
from user_model import users
app = Flask(__name__)




@app.route('/')
def index():
    users.get_all()
    return render_template('create.html')



if __name__ == "__main__":
    app.run(debug=True)