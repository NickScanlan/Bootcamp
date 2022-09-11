from flask_app import app
from flask import render_template, request, redirect
from flask_app.models.user_model import User
#GET ALL 
@app.route('/') # route to show users on the page 
def index():
    all_users = User.get_all() 
    print(all_users)
    return render_template('index.html', all_users = all_users)


#GET ONE
@app.route('/users/<int:id>')
def one_user(id):
    one_user = User.get_one({'id':id})
    return render_template('one_user.html', one_user = one_user)

#NEW USER FORM
@app.route('/users/new') #route that goes to form
def new_user_form():
    return render_template('users_new.html')


##PROCESS NEW DOG FORM 
@app.route('/users/create', methods=['POST'])
def create_user():
    User.create(request.form)
    return redirect('/')


#EDIT USER FORM
@app.route('/users/<int:id>/edit')
def edit_user_form(id):
    data = {
        'id':id
    }
    this_user = User.get_one(data)
    return render_template('users_edit.html', this_user = this_user)

#PROCESS EDIT DOG FORM
@app.route('/users/<int:id>/update', methods=['POST'])
def update_user(id):
    data = {
        **request.form, #quick way to copy the contents of request.form into this dictionary
        'id':id
    }
    User.update(data)
    return redirect('/')


#DELETE DOG BY ID 
@app.route('/users/<int:id>/delete') #route to delete from id
def delete_user(id):
    data = { 
        'id':id
    }
    User.delete(data)
    return redirect('/')