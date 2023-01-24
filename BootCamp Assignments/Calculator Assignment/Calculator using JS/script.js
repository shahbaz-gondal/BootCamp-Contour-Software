function display(value){
    document.getElementById("textarea").value += value;
}
function clearScreen(){
    document.getElementById("textarea").value = "";
    document.getElementById("result").value = "";
}
function calculate()
{
    let p = document.getElementById("textarea").value;
    let q = eval(p);
    document.getElementById("result").value = q;
}