from dataclasses import dataclass
from flask_app import app
from flask import render_template, redirect, flash, request, session
from flask_bcrypt import Bcrypt
from flask_app.models.user_model import User


bcrypt = Bcrypt(app)



@app.route('/')
def index():
    return render_template('index.html')


@app.route('/welcome')
def welcome():
    if not "user_id" in session:
        return redirect('/')
    return render_template('welcome.html')



@app.route('/users/register', methods=['POST'])
def register():
    if not User.validate(request.form):
        return redirect ('/')
    hashed_pw = bcrypt.generate_password_hash(request.form['password'])
    data = {
        **request.form,
        'password': hashed_pw
    }
    session['user_id'] = User.create(data)
    return redirect('/welcome')

@app.route('/users/logout')
def logout():
    del session['user_id']
    return redirect('/')


@app.route('/users/login', methods = ["POST"])
def login():
    data = {
        'email': request.form['email']
    }
    user_from_db = User.get_by_email(data)
    if not user_from_db:
        flash('Invalid Creds', 'log')
        return redirect('/')
    if not bcrypt.check_password_hash(user_from_db.password, request.form['password']):
        flash('Invalid Creds', 'log')
        return redirect('/')
    session['user_id'] = user_from_db.id
    return redirect('/welcome')
