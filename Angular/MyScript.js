//console.log("Hello from typescript")
/*let mystring:string;
let myNumber:number;
let myStatus:boolean;
mystring="TypeScript"
myNumber=120;
myStatus=true;
console.log(mystring);
console.log(myNumber);
console.log(myStatus);*/
/*let mydata:any;
mydata="Hello";
console.log(mydata);
let  mystring:string;
mystring="Welcome to chennai";
console.log(mystring.slice(0,3));
let myNumber:number;
myNumber=100;
console.log(myNumber.toString()+"my result");*/
var User = /** @class */ (function () {
    function User(id, name, email, age) {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.age = age;
        console.log("user created");
    }
    User.prototype.Register = function () {
        console.log(this.Name + " Successfully registered");
        console.log(this.Id + " " + this.Name + " " + this.Email + " " + this.age);
    };
    User.prototype.getAge = function (id) {
        if (this.Id == id)
            return this.age;
        else
            return 0;
    };
    return User;
}());
var cUser = new User(2, "navya", "navi@cts", 21);
cUser.Register();
console.log(cUser.getAge(2));
