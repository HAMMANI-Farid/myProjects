function InsertValue(text){
    if (document.getElementById("CalculSymbol").innerHTML == "") {
        CleanZone("Val1","",true);
    }
    if (document.getElementById("Val2").value == "0") {
        document.getElementById("Val2").value = ""
    }
    document.getElementById("Val2").value += text;
}

function InsertSymbol(text){
    if (document.getElementById("CalculSymbol").innerHTML == "") {
        CleanZone("Val1","",true);
    }
    if (document.getElementById("Val1").value == "") {
        document.getElementById("CalculSymbol").innerHTML = text;
        document.getElementById("Val1").value = document.getElementById("Val2").value;
        CleanZone("Val2","0",false);
    }else{
        Calcul();
    }
}

function CleanZone(Place, text, Symbol){
    document.getElementById(Place).value = text;
    if (Symbol) {
        document.getElementById("CalculSymbol").innerHTML = "";
    }
}

function Calcul(){
    if(document.getElementById("CalculSymbol").innerHTML == "")
    return;

    var Val1 = document.getElementById("Val1").value;
    var Val2 = document.getElementById("Val2").value;
    switch (document.getElementById("CalculSymbol").innerHTML) {
        case '+':
            document.getElementById("Val2").value = parseFloat(Val1) + parseFloat(Val2);
            break;
        case '-':
            document.getElementById("Val2").value = parseFloat(Val1) - parseFloat(Val2);
            break;
        case 'x':
            document.getElementById("Val2").value = parseFloat(Val1) * parseFloat(Val2);
            break;
        case '/':
            if (Val2 == 0) {
                alert("Impossible de diviser par 0!");
                CleanZone("Val1","",false);CleanZone("Val2","0",true);
                return;
            }
            document.getElementById("Val2").value = parseFloat(Val1) / parseFloat(Val2);
            break;
        default:
            if (Val2 == 0) {
                alert("Impossible de diviser par 0!");
                CleanZone("Val1","",false);CleanZone("Val2","0",true);
                return;
            }
            document.getElementById("Val2").value = parseFloat(Val1) % parseFloat(Val2);
            break;
    }
    CleanZone("Val1","",true);
}

function PlusMoins(){
    var Num = document.getElementById("Val2").value;
    if(Num == "0")
    return;
    var BoolN = Num.includes("-");
    if(BoolN){
        document.getElementById("Val2").value = Num.substring(1);
    }else{
        document.getElementById("Val2").value = "-" + Num;
    }
}

function Vergul(){
    var NumV = document.getElementById("Val2").value;
    var BoolV = NumV.includes(".");
    if (BoolV)
    return;
    document.getElementById("Val2").value += ".";
}

function BackSpace(){
    var Num = document.getElementById("Val2").value;
    if (Num == "0") {
        return;
    }
    var Longueur = Num.length;
    if (Longueur == 1) {
        document.getElementById("Val2").value = "0";
        return;
    }
    var NewNum = Num.substring(0,Longueur-1);
    document.getElementById("Val2").value = NewNum;
}

function SqrtResult(){
    var Num = document.getElementById("Val2").value;
    document.getElementById("Val1").value = "Sqrt(" + Num + ")";
    document.getElementById("Val2").value = Math.sqrt(parseFloat(Num));
}

function PowerResult(){
    var Num = document.getElementById("Val2").value;
    document.getElementById("Val1").value = Num + "²";
    document.getElementById("Val2").value = Math.pow(parseFloat(Num),2);
}

function OneResult(){
    var Num = document.getElementById("Val2").value;
    if (Num == 0) {
        alert("Impossible de diviser par 0!");
        CleanZone("Val1","",false);CleanZone("Val2","0",true);
        return;
    }
    document.getElementById("Val1").value = "1 / " + Num;
    document.getElementById("Val2").value = 1/parseFloat(Num);
}

$(document).ready(function(){
    $(".Title").animate({
        height: "150px"
    },"slow",function(){
        $(".Calculatrise").fadeIn("slow", function(){
            $("footer h2").fadeIn("slow");
        });
    });
    
});
    
