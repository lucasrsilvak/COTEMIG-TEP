function telephoneMask()
{
    console.log('bop');
    var tel = document.getElementById("telephone").value;

    if (tel[0] != "(") {
        if (tel[0] != undefined) {
            document.getElementById("telephone").value = "(" + tel[0];
        }
    }

    if (tel[3] != ")") {
        if (tel[3] != undefined) {
            document.getElementById("telephone").value = tel.slice(0, 3) + ")" + tel[3];
        }
    }

    if (tel[4] != " ") {
        if (tel[4] != undefined) {
            document.getElementById("telephone").value = tel.slice(0, 4) + " " + tel[4] + tel[5];
        }
    }

    if (tel[10] != "-") {
        if (tel[10] != undefined) {
            document.getElementById("telephone").value = tel.slice(0, 10) + "-" + tel[10];
        }
    }
}

function  removeAlert()
{
    document.getElementById("Help").innerHTML = "";
    document.getElementById("Help2").innerHTML = "";
}