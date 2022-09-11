
from flask_app.config.mysqlconnections import connectToMySQL
DATABASE = 'users_schema' # "DATABASE =" is to help so that we don't have to rewrite our database name if we need to change said database. 

class User:
    def __init__(self,data): #constuctor
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    
    @classmethod #query to show all users
    def get_all(cls):
        query = 'SELECT * FROM users;'
        results = connectToMySQL(DATABASE).query_db(query)
        print(results)
        all_users = []
        for row_from_db in results:
            user_instance = cls(row_from_db) #instantiates user object from row in database
            all_users.append(user_instance) #adds instance to list of instances
        return all_users #list of all user instances

    @classmethod #query to create a new user 
    def create(cls,data):
        query = 'INSERT INTO users (first_name, last_name, email) VALUES (%(first_name)s, %(last_name)s, %(email)s);'
        return connectToMySQL(DATABASE).query_db(query,data)

    @classmethod #query to choose one user 
    def get_one(cls, data):
        query = 'SELECT * FROM users WHERE id = %(id)s;'
        results = connectToMySQL(DATABASE).query_db(query,data)
        if len(results) > 0:
            user_instance = cls(results[0])
            return user_instance
        return False

    @classmethod #query to update user value
    def update(cls,data):
        query = 'UPDATE users SET first_name = %(first_name)s, last_name = %(last_name)s, email = %(email)s WHERE id = %(id)s;'
        return connectToMySQL(DATABASE).query_db(query,data)

    @classmethod #query to delete from id
    def delete(cls,data):
        query = 'DELETE FROM users WHERE id = %(id)s'
        return connectToMySQL(DATABASE).query_db(query,data)
