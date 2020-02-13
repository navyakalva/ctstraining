const PRODUCTS_KEY = "products";

function getProductsFromLocalStorage() {
    let products = [];

    if (localStorage.getItem(PRODUCTS_KEY)) {
        products = JSON.parse(localStorage.getItem(PRODUCTS_KEY));
    }

    return products;
}

function addItemFormSubmit() {
    //focus();
    //validate();
    //movetoNext(current, nextFieldID);

    let products = getProductsFromLocalStorage();

    let buyername = document.querySelector("#buyername");
    let shippingaddress = document.querySelector("#Text1");
    let city = document.querySelector("#city");
    let amount = document.querySelector("#amount");
    let v1 = document.querySelector("#ph1");
    let v2 = document.querySelector("#ph2");
    let v3 = document.querySelector("#ph3");
    let v4 = document.querySelector("#ph4");
    let v5 = document.querySelector("#ph5");
    let v6 = document.querySelector("#ph6");
    let v7 = document.querySelector("#ph7");
    let v8 = document.querySelector("#ph8");
    let v9 = document.querySelector("#ph9");
    let v10 = document.querySelector("#ph10")
    let phone = (" " + v1.value + v2.value + v3.value + v4.value + v5.value + v6.value + v7.value + v8.value + v9.value + v10.value);

    let product = {

        buyername: buyername.value,
        shippingaddress: (shippingaddress.value),
        city: (city.value),
        amount: parseInt(amount.value),
        phone: (phone)
    };

    products.push(product);
    localStorage.setItem(PRODUCTS_KEY, JSON.stringify(products));
}

function loadItems() {
    let products = getProductsFromLocalStorage();

    let tableBody = document.querySelector("#prdData");

    /*    products.forEach(product => {
            let prdRow = createProductRow(product);
            tableBody.append(prdRow);
        }); */

    for (let product of products) {
        let prdRow = createProductRow(product);
        tableBody.append(prdRow);
    }
}

function createProductRow(product) {

    let buyercol = document.createElement("td");
    buyercol.textContent = product.buyername;

    let addresscol = document.createElement("td");
    addresscol.textContent = product.shippingaddress;

    let citycol = document.createElement("td");
    citycol.textContent = product.city;

    let amountcol = document.createElement("td");
    amountcol.textContent = product.amount;

    let phonecol = document.createElement("td");
    phonecol.textContent = product.phone;


    let prdRow = document.createElement("tr");
    prdRow.append(buyercol);
    prdRow.append(addresscol);
    prdRow.append(citycol);
    prdRow.append(amountcol);
    prdRow.append(phonecol);


    return prdRow;
}

function validate() {
    var a = document.getElementById("amount").value;
    var b = document.getElementById("pai").value;
    if (b < 0 || b > 100) {
        alert(" paisa value must be betweem 0 and 100");
        document.getElementById("pai").focus();
        return false;
    }

    var a = document.getElementById("fname").value;
    var b = document.getElementById("lname").value;
    if (!isNaN(a)) {
        alert("Enter Only Characters for name ");
        document.getElementById("fname").focus();
        return false;
    }
    if (!isNaN(b)) {
        alert("Enter Only Characters Last name");
        document.getElementById("lname").focus();
        return false;
    }
    var b = document.getElementById("city").value;
    if (!isNaN(b)) {
        alert("Enter Only Characters for City name");
        document.getElementById("city").focus();
        return false;
    }
    //var b = document.getElementById("t6").value;

    //if (!isNaN(b)) {
    //    alert("Enter Only Characters");
    //    document.getElementById("t6").focus();
    //    return false;
    //}

    //var b = document.getElementById("t7").value;
    //if (b == "") {
    //    document.getElementById("t7").focus();
    //}
    //if (!isNaN(b)) {
    //    alert("Enter Only Characters");
    //    document.getElementById("ctry").focus();
    //    return false;
    //}
    //if (document.form.sel.SelectedIndex == 0) {
    //    alert("Select One");
    //    document.form.sel.focus();
    //    return false;
    //}
    var a = document.getElementById("pin").value;
    if (a.length > 6 || a.length < 6) {
        alert("Enter 6 number for pin code");
        document.getElementById("pin").focus();
        return false;
    }
    var a = document.getElementById("buyername").value;
    var b = document.getElementById("blast").value;
    if (!isNaN(a)) {
        alert("Enter Only Characters for buyer name ");
        document.getElementById("bname").focus();
        return false;
    }
    if (!isNaN(b)) {
        alert("Enter Only Characters buyer last name");
        document.getElementById("blast").focus();
        return false;
    }
   
    addItemFormSubmit()
}
function f11() {
    document.getElementById("amount").focus();
}
function movetoNext(current, nextFieldID) {
    if (current.value.length >= current.maxLength) {
        document.getElementById(nextFieldID).focus();
    }
}
function remove() {
    localStorage.clear();
}


