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

//arrays

/*let mysArray:string[];
let mynArray:number[];
mysArray=["HEllo","typescript"];
mynArray=[1,2,3,4];
console.log(mysArray);
console.log(mynArray);
console.log(mynArray[1]);
for(var n=0;n<mynArray.length;n++)
{
    console.log(mynArray[n]);
}
mysArray.forEach(function(value)
{console.log(value);})*/
/*let myTuple:[string,number,number]
myTuple=["typescript",1,3];
console.log(myTuple);
let myvar:void;      
myvar=undefined;
console.log(myvar);
let myvar1:null;
myvar1=null;
console.log(myvar1);
console.log(myTuple.pop());
myTuple.push(23);
console.log(myTuple);*/

//Enum

/*enum myEnum{sunday=0,monday,tuesday,wednesday};
console.log(myEnum.tuesday);
//functions
function myfunction(num1:number,num2:number):number
{
     return num1+num2;
}
console.log(myfunction(23,78));
function addfunction(num1:any,num2:any):any
{
     return num1+num2;
}
console.log(addfunction("hi",78));
function addnumber(num1:any,num2:any):number
{
    if(typeof(num1)=='string'&&typeof(num2)=='string')
    {
       let x:number;
       let y:number;
       x=parseInt(num1);
       y=parseInt(num2);
       return(x+y);
    }
    else
    return (num1+num2);
}
console.log(addnumber("23","34"));
function getname(firstname:string,lastname:string)
{
    if(lastname==undefined)return firstname;
    return(firstname+" "+lastname);
}
console.log(getname("John","Dave"));*/

//interface

/*interface myinterface
{
    Name:string;
    Title:string;
}
function Ifunction(mydata:myinterface):string
{
     return(mydata.Name+" "+mydata.Title);
}
let dat={Name:"David",Title:"Assionate"}
console.log(Ifunction(dat));*/

//class

/*class User
{
    Id:number;
    Name:string;
    Email:string;
    age:number;
    constructor(id:number,name:string,email:string,age:number)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.age=age;
        console.log("user created");
    }
}
let firstUser=new User(1,"Anil","navi@cts.com",21);
console.log(firstUser.Id+" "+firstUser.Name+" "+firstUser.Email+" "+firstUser.age);*/

//class with functions

/*class User
{
    Id:number;
    Name:string;
    Email:string;
    age:number;
    constructor(id:number,name:string,email:string,age:number)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.age=age;
        console.log("user created");
    }
    Register()
    {
        console.log(this.Name+ " Successfully registered");
        console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.age);
    }
    getAge(id:number):number
    {
       if(this.Id==id)
       return this.age;
       else
       return 0;
    }
}
    let firstUser=new User(1,"Anil","navi@cts.com",21);
    firstUser.Register();
    console.log(firstUser.getAge(1));*/

    /*class User
    {
        protected Id:number;
        protected Name:string;
        protected Email:string;
        protected age:number;
    
        constructor(id:number,name:string,email:string,age:number)
        {
            this.Id=id;
            this.Name=name;
            this.Email=email;
            this.age=age;
            console.log("user created");
        }
        Register()
        {
            console.log(this.Name+ " Successfully registered");
            console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.age);
        }
        getAge(id:number):number
        {
           if(this.Id==id)
           return this.age;
           else
           return 0;
        }
    }
    class AdminUser extends User
    {
        Type:string;
        constructor (id:number,name:string,email:string,age:number,type:string)
        {
            super(id,name,email,age);
            this.Type=type;
        }
        displayAdmin()
        {
            console.log()
            console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.age+" "+this.Type);
        }
    }
    let cuser=new AdminUser(2,"raj","raj@cts",25,"savings");
    cuser.displayAdmin();*/

     interface Iuser
    {
        Id:number;
        Name:string;
        Email:string;
        age:number;
        Register():void;
        getAge(id:number):number;
    }
    class User implements Iuser
    {
         Id:number;
         Name:string;
         Email:string;
         age:number;
        constructor(id:number,name:string,email:string,age:number)
        {
            this.Id=id;
            this.Name=name;
            this.Email=email;
            this.age=age;
            console.log("user created");
        }
        Register()
        {
            console.log(this.Name+ " Successfully registered");
            console.log(this.Id+" "+this.Name+" "+this.Email+" "+this.age);
        }
        getAge(id:number):number
        {
           if(this.Id==id)
           return this.age;
           else
           return 0;
        }
    }
    let cUser=new User(2,"navya","nAvi@cts",21);
    cUser.Register();
    console.log(cUser.getAge(2));
   