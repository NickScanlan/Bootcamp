from flask import Flask, render_template 
app = Flask(__name__)   


@app.route('/play')
def template():
    number = 3
    color = 'aqua'
    return render_template('index.html', number = number, color = color)

@app.route('/play/<int:number>')
def blockNum(number):
    color = 'aqua'
    return render_template('index.html', number = number, color = color)

@app.route('/play/<int:number>/<color>')
def blockColor(number, color):
        return render_template('index.html', number = number, color = color)



if __name__=="__main__":    
    app.run(debug=True)   
