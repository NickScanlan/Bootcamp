from flask_app import app
from flask import render_template, redirect, flash, request, session
from flask_app.models.user_model import User
from flask_app.models.sighting_model import Sighting

@app.route('/see/new')
def new_sighting_form():
    print('we made it======================')
    if "user_id" not in session:
        return redirect('/')
    # logged_user = User.get_by_id({'id':session['user_id']})
    return render_template('sightings_new.html')


@app.route("/sightings/create", methods = ["POST"])
def process_sighting():
    if 'user_id' not in session:
        return redirect('/')
    if not Sighting.validation(request.form):
        return redirect('/see/new')
    data = {
        **request.form,
        'user_id': session['user_id']
    }
    id =Sighting.create(data)
    return redirect(f"/sightings/{id}")


@app.route('/sightings/<int:id>/delete')
def del_sighting(id):
    if 'user_id' not in session:
        return redirect('/')
    sighting = Sighting.get_by_id({'id':id})
    if not int(session['user_id']) == sighting.user_id:
        flash('bruh...?')
        return redirect('/welcome')
    Sighting.delete({'id': id})
    return redirect('/welcome') 



@app.route('/sightings/<int:id>/edit')
def edit_sighting_form(id):
    if 'user_id' not in session:
       return redirect('/')
    sighting = Sighting.get_by_id({'id':id})
    if not int(session['user_id']) == sighting.user_id:
        flash("bruh...")
        return redirect ('/welcome')
    sighting = Sighting.get_by_id({'id':id})
    return render_template("sightings_edit.html", sighting = sighting)



@app.route('/sightings/<int:id>/update', methods = ['POST'])
def update_sightings(id):
    if 'user_id' not in session:
        return redirect('/')
    sighting = Sighting.get_by_id({'id':id})
    if not int(session['user_id']) == sighting.user_id:
        flash('bruh...?')
        return redirect('/welcome')
    if not Sighting.validation(request.form):
        return redirect(f"/sightings/{id}/edit")
    data = { 
        **request.form,
        'id':id
    }
    Sighting.update(data)
    return redirect ('/welcome')

@app.route("/sightings/<int:id>")
def show_sightings(id):
    sighting = Sighting.get_by_id({'id':id})
    return render_template('sightings_one.html', sighting = sighting)
    