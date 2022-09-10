from flask import Flask, render_template, session, request, redirect
from flask_app.models.user_model import users
app = Flask(__name__)




@app.route('/')
def index():
    all_users = users.get_all()
    print(all_users)
    return render_template('index.html', all_users = all_users)

@app.route('/form')
def user_form():
    return render_template('form.html')

@app.route('/create', methods=['POST'])
def create_user():
    users.create(request.form)
    return redirect('/')



if __name__ == "__main__":
    app.run(debug=True)