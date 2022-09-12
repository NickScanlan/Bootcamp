from flask_app import app
from flask import render_template, redirect, session, request

from flask_app.models import users_model

@app.route('/')
def index():
    return render_template('index.html')


@app.route('/user/new')
def new_user():
    return render_template('new_user.html')


@app.route('/user/create', methods = ['POST'])
def create_user():
    return redirect('/')


@app.route('/user/<int:id>')
def show_user(id):
    return render_template('show_user.html')


@app.route('/user/<int:id>/edit')
def edit_user(id):
    return render_template('edit.html')


@app.route('/user/<int:id>/ update', methods = ['POST'])
def update_user(id):
    return redirect('/')


@app.route('/user/<int:id>/delete')
def delete_user(id):
    return redirect('/')