from flask_app import app
from flask import render_template, redirect, flash, request, session
from flask_app.models.user_model import User
from flask_app.models.recipes_model import Recipe

@app.route('/recipes/new')
def new_recipe_form():
    if "user_id" not in session:
        return redirect('/')
    # logged_user = User.get_by_id({'id':session['user_id']})
    return render_template('recipes_new.html')


@app.route("/recipes/create", methods = ["POST"])
def process_recipe():
    if 'user_id' not in session:
        return redirect('/')
    if not Recipe.validation(request.form):
        return redirect('/recipes/new')
    data = {
        **request.form,
        'user_id': session['user_id']
    }
    id =Recipe.create(data)
    return redirect(f"/recipes/{id}")


@app.route('/recipes/<int:id>/delete')
def del_recipe(id):
    if 'user_id' not in session:
        return redirect('/')
    recipe = Recipe.get_by_id({'id':id})
    if not int(session['user_id']) == recipe.user_id:
        flash('bruh...?')
        return redirect('/welcome')
    Recipe.delete({'id': id})
    return redirect('/welcome') 



@app.route('/recipes/<int:id>/edit')
def edit_recipe_form(id):
    if 'user_id' not in session:
       return redirect('/')
    recipe = Recipe.get_by_id({'id':id})
    if not int(session['user_id']) == recipe.user_id:
        flash("bruh...")
        return redirect ('/welcome')
    recipe = Recipe.get_by_id({'id':id})
    return render_template("recipes_edit.html", recipe = recipe)



@app.route('/recipes/<int:id>/update', methods = ['POST'])
def update_recipe(id):
    if 'user_id' not in session:
        return redirect('/')
    recipe = Recipe.get_by_id({'id':id})
    if not int(session['user_id']) == recipe.user_id:
        flash('bruh...?')
        return redirect('/welcome')
    if not Recipe.validation(request.form):
        return redirect(f"/recipes/{id}/edit")
    data = { 
        **request.form,
        'id':id
    }
    Recipe.update(data)
    return redirect ('/welcome')

@app.route("/recipes/<int:id>")
def show_recipe(id):
    recipe = Recipe.get_by_id({'id':id})
    return render_template('recipes_one.html', recipe = recipe)
    