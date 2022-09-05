from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'bababooey'

@app.route('/')
def home():
    return render_template('index.html')

@app.route('/process', methods=['POST'])
def process():
    print(request.form)
    session ['user_name'] = request.form['user_name']
    session ['user_location'] = request.form['user_location']
    session ['user_language'] = request.form['user_language']
    session ['user_comment'] = request.form['user_comment']
    return redirect('/result')

@app.route('/result')
def result():
    return render_template('result.html')

@app.route('/clear')
def clear():
    session.clear()  
    return redirect('/')


if __name__=="__main__":
    app.run(debug=True)    