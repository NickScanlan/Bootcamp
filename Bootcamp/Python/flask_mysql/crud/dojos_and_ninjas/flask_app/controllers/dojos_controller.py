from flask_app import app
from flask import render_template, request, redirect
from flask_app.models.dojo_model import Dojo

#GET ALL 
@app.route('/')
def index():
    all_dojos = Dojo.get_all()
    print(all_dojos)
    return render_template('index.html', all_dojos = all_dojos)


#GET ONE
@app.route('/dojos/<int:id>')
def one_dojo(id):
    one_dojo = Dojo.get_one_with_ninjas({'id':id})
    return render_template('one_dojo.html', one_dojo = one_dojo)

#NEW DOJO FROM 
@app.route('/dojos/new')
def new_dog_form():
    return render_template('dojos_new.html')

#PROCESS NEW DOJO FORM 
@app.route('/dojos/create', methods=['POST'])
def create_dojo():
    Dojo.create(request.form)
    return redirect('/')

#EDIT DOJO FORM 
@app.route('/dojos/<int:id>/edit')
def edit_dog_form(id):
    data = {
        'id':id
    }
    this_dojo = Dojo.get_one(data)
    return render_template('dojos_edit.html', this_dojo = this_dojo)

#PROCESS EDIT DOJO FORM 
@app.route('/dojos/<int:id>/update', methods = ['POST'])
def update_dojo(id):
    data = {
        **request.form,
        'id':id 
}
    Dojo.update(data)
    return redirect('/')


#DELETES A DOJO BY ID 

@app.route('/dojos/<int:id>/delete')
def delete_dojo(id):
    data = {
        'id':id 
    }
    Dojo.delete(data)
    return redirect('/')

