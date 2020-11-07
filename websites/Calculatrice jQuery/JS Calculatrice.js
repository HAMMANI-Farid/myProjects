$(document).ready(function(){
    $("body").css({
        "width": "100%",
        "margin": "0px",
        "padding": "0px",
        "background-color": "whitesmoke",
        "font-family": "arial",
        "position": "relative"
    });
    
    $("header").css({
        "width": "100%",
        "height": "0px",
        "background-color": "#2196F3",
        "position": "relative",
        "padding-top": "20px"
    });

    $("header h2").css({
        "text-align": "center",
        "color": "white",
        "font-size": "30px",
        "font-width": "bold",
    });

    $(".Types").css({
        "width": "100%",
        "height": "50px",
        "position": "absolute",
        "margin-top": "0px",
        "z-index": "1"
    });

    $(".Types div").css({
        "width": "33.33%",
        "height": "100px",
        "float": "left",
    });

    $(".Types button").css({
        "width": "100%",
        "height": "50px",
        "border": "none",
        "font-size": "17px",
        "font-wieght": "bold",
        "color": "white",
        "background-color": "#1F1C29"
    });

    $("footer").css({
        "width": "100%",
        "height": "80px",
        "border": "none",
        "bottom": "0px",
        "padding-top": "30px",
        "background-color": "#1F1C29",
        "display": "none"
    });

    $("footer h2").css({
        "font-size": "20px",
        "font-weight": "bold",
        "text-align": "center",
        "color": "white"
    })

    $("header").animate({
        height: "120px"
    }, function(){
        $(".s").fadeIn("slow", function(){
            $("footer").slideDown("fast")
        });
    });

    $(window).scroll(function(){
        if ($(window).scrollTop() >= 140) {
            $(".Types").css({
                "margin-top": "-140px",
                "position": "fixed"
            });
        }else{
            $(".Types").css({
                "margin-top": "0px",
                "position": "absolute"
            });
        }
    });

    $(".s").css({
        "width": "45%",
        "height": "540px",
        "border": "none",
        "border-radius": "10px",
        "background-color": "#2196F3",
        "box-shadow": "0px 0px 10px 0px black",
        "margin": "90px auto",
        "padding-top": "20px",
        "position": "abbsolute",
        "display": "none"
    });

    $(".Valeurs").css({
        "width": "90%",
        "height": "150px",
        "margin": "0px auto",
        "border": "none",
        "border-radius": "10px",
        "background-color": "white",
    })

    $(".Valeurs div").css({
        "width": "100%",
        "height": "50px",
        "text-align": "right"
    });

    $(".Valeurs input").css({
        "height": "30px",
        "width": "94%",
        "border": "none",
        "font-size": "17px",
        "font-weight": "bold",
        "text-align": "right",
        "margin-left": "1%",
        "margin-right": "2%",
        "padding": "0px 10px"
    });

    $(".Buttons").css({
        "width": "100%",
        "height": "100%"
    });

    $(".Buttons div").css({
        "width": "90%",
        "height": "40px",
        "margin": "0px auto",
        "padding-top": "20px",
        "padding-left": "2%"
    });

    $(".Buttons button").css({
        "width": "24%",
        "height": "50px",
        "font-size": "15px",
        "font-weight": "bolder",
        "border": "none",
        "border-radius": "10px",
        "background-color": "white"
    });

    $(".Types button").bind({
        mouseenter: function(){
            $(this).css({
                "color": "black",
                "background-color": "#09E4FE"
            })
        },
        mousedown: function(){
            $(this).css({
                "color": "white",
                "background-color": "#44BFE6"
            })
        },
        mouseup: function(){
            $(this).css({
                "color": "black",
                "background-color": "#09E4FE"
            })
        },
        mouseleave: function(){
            $(this).css({
                "color": "white",
                "background-color": "#1F1C29"
            })
        }
    });
        
        $(".Buttons button").on({
            mouseenter: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "#09E4FE"
                })
            },
            mousedown: function(){
                $(this).css({
                    "color": "white",
                    "background-color": "#44BFE6"
                })
            },
            mouseup: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "#09E4FE"
                })
            },
            mouseleave: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "white"
                })
            }
        });

        var typeCalcul = 1;

        $(".stand").on({
            click: function(){
                if (typeCalcul == 2) {
                    $(".sc").fadeOut("fast", function(){
                        $(".s").fadeIn("fast");
                    });
                }else{
                    $(".p").fadeOut("fast", function(){
                        $(".s").fadeIn("fast");
                    });
                }
                typeCalcul = 1;
            }
        });

        $(".scien").on({
            click: function(){
                if (typeCalcul == 1) {
                    $(".s").fadeOut("fast", function(){
                        $(".sc").fadeIn("fast");
                    });
                }else{
                    $(".p").fadeOut("fast", function(){
                        $(".sc").fadeIn("fast");
                    });
                }
                typeCalcul = 2;
            }
        });

        $(".progr").on({
            click: function(){
                if (typeCalcul == 1) {
                    $(".s").fadeOut("fast", function(){
                        $(".p").fadeIn("fast");
                    });
                }else{
                    $(".sc").fadeOut("fast", function(){
                        $(".p").fadeIn("fast");
                    });
                }
                typeCalcul = 3;
            }
        });

        function ClearZone(zone, str){
            $(zone).val(str);
            $(zone).text(str);
        };

        function VerifierZone(){
            if ($(".Val1").val() != "" && $(".CalSyb").text() == "") {
                ClearZone(".Val1", "");
            }
        };

        function WriteNumber(cls, zone, number){
            $(cls).on({
                click: function(){
                    VerifierZone();
                    if ($(zone).val() == "0") {
                        $(zone).val("")
                    }
                    $(zone).val($(zone).val() + number)
                }
            });
        };

        var fautCalcul = false;

        function Calcul(valeur1 , valeur2, zone1 ,zone2, symbol, clearPlace){
            VerifierZone();
            switch (symbol) {
                case '+':
                    $(zone2).val(parseFloat(valeur1) + parseFloat(valeur2));
                    break;
                case '-':
                    $(zone2).val(parseFloat(valeur1) - parseFloat(valeur2));
                    break;
                case 'x':
                    $(zone2).val(parseFloat(valeur1) * parseFloat(valeur2));
                    break;
                case '/':
                    if (valeur2== "0") {
                        alert("Impossible de diviser par 0!");
                        ClearZone(zone2, "0");fautCalcul = true;
                        break;
                    }
                    $(zone2).val(parseFloat(valeur1) / parseFloat(valeur2));
                    break;
                default:
                    if (valeur2 == "0") {
                        alert("Impossible de diviser par 0!");
                        ClearZone(zone2, "0");fautCalcul = true;
                        break;
                    }
                    $(zone2).val(parseFloat(valeur1) % parseFloat(valeur2));
                    break;
            }
            if (clearPlace) {
                ClearZone(zone1, "");ClearZone(".CalSyb", "");
            }
        };

        function CalculValues(symbol){
            VerifierZone();
            if ($(".Val1").val() == "") {
                $(".Val1").val($(".Val2").val());
                ClearZone(".Val2","0");
                $(".CalSyb").text(symbol);
            }else{
                Calcul($(".Val1").val(), $(".Val2").val(), ".Val1", ".Val2", $(".CalSyb").text(), true);
            }
        };

        WriteNumber(".n0", ".Val2", "0");
        WriteNumber(".n1", ".Val2", "1");
        WriteNumber(".n2", ".Val2", "2");
        WriteNumber(".n3", ".Val2", "3");
        WriteNumber(".n4", ".Val2", "4");
        WriteNumber(".n5", ".Val2", "5");
        WriteNumber(".n6", ".Val2", "6");
        WriteNumber(".n7", ".Val2", "7");
        WriteNumber(".n8", ".Val2", "8");
        WriteNumber(".n9", ".Val2", "9");

        $(".s1").on({
            click: function(){
                CalculValues('+');
            }
        });

        $(".s2").on({
            click: function(){
                CalculValues('-');
            }
        });

        $(".s3").on({
            click: function(){
                CalculValues('x');
            }
        });

        $(".s4").on({
            click: function(){
                CalculValues('/');
            }
        });

        $(".s5").on({
            click: function(){
                CalculValues('%');
            }
        });

        $(".s6").on({
            click: function(){
                if ($(".Val1").val() == "") {
                    return;
                }
                Calcul($(".Val1").val(), $(".Val2").val(), ".Val1", ".Val2", $(".CalSyb").text(), true);
            }
        });

        $(".c").on({
            click: function(){
                ClearZone(".Val1", "");ClearZone(".Val2", "0");ClearZone(".CalSyb", "");
            }
        });

        $(".ce").on({
            click: function(){
                ClearZone(".Val2", "0");
            }
        });

        function BackSpace(zone){
            var valeur = $(zone).val();
                if (valeur.length == 1) {
                    ClearZone(zone, "0");
                }else{
                    $(zone).val(valeur.substring(0, valeur.length-1));
                }
        };

        $(".bs").on({
            click: function(){
                VerifierZone();
                BackSpace(".Val2");
            }
        });

        function Vergul(zone){
            var valeur = $(zone).val();
            if (valeur.includes('.')) {
                return;
            }
            $(zone).val(valeur + '.');
        };

        $(".vergul").on({
            click: function(){
                VerifierZone();
                Vergul(".Val2");
            }
        });

        function PlusMoins(zone){
            var valeur = $(zone).val();
                if (valeur == "0") {
                    return;
                }
                if (valeur.includes('-')) {
                    $(zone).val(valeur.substring(1, valeur.length));
                }else{
                    $(zone).val('-' + valeur);
                }
        };

        $(".plusMoins").on({
            click: function(){
                VerifierZone();
                PlusMoins(".Val2");
            }
        });

        function fact(nombre){
            if (nombre > 1) {
                return nombre * fact(nombre - 1);
            }else{
                return 1;
            }
        }

        function CalculMore(zone1, zone2, type){
            switch (type) {
                case "sqrt":
                    $(zone1).val("Sqrt(" + $(zone2).val() + ")");
                    $(zone2).val(Math.sqrt(parseFloat($(zone2).val())));
                    break;
                case "power":
                    $(zone1).val($(zone2).val() + '²');
                    $(zone2).val(Math.pow(parseFloat($(zone2).val()), 2));
                    break;
                case "div":
                    if ($(zone2).val() == "0") {
                        alert("Impossible de diviser par 0!");
                        ClearZone(zone1, "");ClearZone(zone2, "0");ClearZone(".CalSyb", "");
                        return;
                    }
                    $(zone1).val("1/" + $(zone2).val());
                    $(zone2).val(1/parseFloat($(zone2).val()));
                    break;
                case "fact":
                    $(zone1).val("Fact(" + $(zone2).val() + ")");
                    $(zone2).val(fact(parseFloat($(zone2).val())));
                    break;
                case "pi":
                    $(zone1).val("Pi");
                    $(zone2).val(Math.PI);
                    break;
                case "cos":
                    $(zone1).val("Cos(" + $(zone2).val() + ")");
                    $(zone2).val(Math.cos(parseFloat($(zone2).val())));
                    break;
                case "sin":
                    $(zone1).val("Sin(" + $(zone2).val() + ")");
                    $(zone2).val(Math.sin(parseFloat($(zone2).val())));
                    break;
                case "tan":
                    $(zone1).val("Tan(" + $(zone2).val() + ")");
                    $(zone2).val(Math.tan(parseFloat($(zone2).val())));
                    break;
                case "log":
                    $(zone1).val("Log(" + $(zone2).val() + ")");
                    $(zone2).val(Math.log(parseFloat($(zone2).val())));
                    break;
                case "exp":
                    $(zone1).val("Exp(" + $(zone2).val() + ")");
                    $(zone2).val(Math.exp(parseFloat($(zone2).val())));
                    break;
                case "powery":
                    $(zone1).val($(zone1).val() + " ^ " + $(zone2).val());
                    $(zone2).val(Math.pow(parseFloat($(zone1).val()), parseFloat($(zone2).val())));
                    break;
                case "teen":
                    $(zone1).val("10 ^ " + $(zone2).val());
                    $(zone2).val(Math.pow(10, parseFloat($(zone2).val())));
                    break;
                default:
                    break;
            }
        };

        $(".sqrt").on({
            click: function(){
                CalculMore(".Val1", ".Val2", "sqrt");
            }
        });

        $(".power").on({
            click: function(){
                CalculMore(".Val1", ".Val2", "power");
            }
        });

        $(".div").on({
            click: function(){
                CalculMore(".Val1", ".Val2", "div");
            }
        });

        $(".sc").css({
            "width": "45%",
            "height": "540px",
            "border": "none",
            "border-radius": "10px",
            "background-color": "#2196F3",
            "box-shadow": "0px 0px 10px 0px black",
            "margin": "90px auto",
            "padding-top": "20px",
            "display": "none"
        });

        $(".Valeurs2").css({
            "width": "94%",
            "height": "150px",
            "margin": "0px auto",
            "border": "none",
            "border-radius": "10px",
            "background-color": "white",
        });

        $(".Valeurs2 div").css({
            "width": "100%",
            "height": "75px",
            "text-align": "right",
        });

        $(".Valeurs2 input").css({
            "height": "30px",
            "width": "94%",
            "border": "none",
            "font-size": "17px",
            "font-weight": "bold",
            "text-align": "right",
            "margin-top": "25px",
            "margin-left": "1%",
            "margin-right": "2%",
            "padding": "0px 10px"
        });

        $(".Buttons2").css({
            "width": "100%",
            "height": "100%"
        });
    
        $(".Buttons2 div").css({
            "width": "95%",
            "height": "40px",
            "margin": "0px auto",
            "padding-top": "13px",
            "padding-left": "2%"
        });
    
        $(".Buttons2 button").css({
            "width": "19%",
            "height": "40px",
            "font-size": "15px",
            "font-weight": "bolder",
            "border": "none",
            "border-radius": "10px",
            "background-color": "white"
        });

        $(".Buttons2 button").on({
            mouseenter: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "#09E4FE"
                })
            },
            mousedown: function(){
                $(this).css({
                    "color": "white",
                    "background-color": "#44BFE6"
                })
            },
            mouseup: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "#09E4FE"
                })
            },
            mouseleave: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "white"
                })
            }
        });

        

        WriteNumber(".n02", ".Val4", "0");
        WriteNumber(".n12", ".Val4", "1");
        WriteNumber(".n22", ".Val4", "2");
        WriteNumber(".n32", ".Val4", "3");
        WriteNumber(".n42", ".Val4", "4");
        WriteNumber(".n52", ".Val4", "5");
        WriteNumber(".n62", ".Val4", "6");
        WriteNumber(".n72", ".Val4", "7");
        WriteNumber(".n82", ".Val4", "8");
        WriteNumber(".n92", ".Val4", "9");

        var NumOpen = 0, NumClose = 0;

        $(".c2").bind({
            click: function(){
                ClearZone(".Val3", "");ClearZone(".Val4", "0");
                NumOpen = 0; NumClose = 0; Symbol = '';
            }
        });

        $(".ce2").bind({
            click: function(){
                ClearZone(".Val4", "0");
            }
        });

        $(".bs2").bind({
            click: function(){
                BackSpace(".Val4");
            }
        });

        $(".pm2").bind({
            click:  function(){
                PlusMoins(".Val4");
            }
        });

        $(".vergul2").bind({
            click: function(){
                Vergul(".Val4");
            }
        });

        $(".sqrt2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "sqrt");
            }
        });

        $(".fact2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "fact");
            }
        });

        $(".power2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "power");
            }
        });

        $(".div2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "div");
            }
        });

        $(".Pi").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "pi");
            }
        });

        $(".cos2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "cos");
            }
        });

        $(".sin2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "sin");
            }
        });

        $(".tan2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "tan");
            }
        });

        $(".log2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "log");
            }
        });

        $(".exp2").bind({
            click: function(){
                CalculMore(".Val3", ".Val4", "exp");
            }
        });

        $(".powery2").bind({
            click: function(){
                if ($(".Val3").val() == "") {
                    $(".Val3").val($(".Val4").val());
                    ClearZone(".Val4", "0");
                }else{
                    CalculMore(".Val3", ".Val4", "powery");
                }
            }
        });

        $(".teen2").bind({
            click: function(){
                if ($(".Val4").val() < 309) {
                    CalculMore(".Val3", ".Val4", "teen");
                }else{
                    alert("Dépassement de capacité!");
                    ClearZone(".Val3", "");ClearZone(".Val4", "0");
                }
            }
        });

        $(".open2").bind({
            click: function(){
                if (NumOpen == 25) {
                    return;
                }
                $(".Val3").val('(' + $(".Val3").val());
                NumOpen += 1;
            }
        });

        $(".close2").bind({
            click: function(){
                if (NumClose == NumOpen) {
                    return;
                }
                if ($(".Val3").val().includes($(".Val4").val())) {
                    $(".Val3").val($(".Val3").val() + ')');
                }else{
                    $(".Val3").val($(".Val3").val() + $(".Val4").val() + ')');
                }
                NumClose += 1;
            }
        });

        var Num = 0, Symbol = '', booly = false;

        function SymbolClick(zone1, zone2, sym){
            // if ($(zone1).val().includes('(')) {
            //     $(zone1).val($(zone1).val() + $(zone2).val() + sym);
            //     Symbol = sym; Num = parseFloat($(zone2).val());
            //     ClearZone(zone2, "0");
            //     return;
            // }
            if ($(zone1).val() == "") {
                $(zone1).val($(zone2).val() + sym);
                Symbol = sym; Num = parseFloat($(zone2).val());
                ClearZone(zone2, "0");
            }
            else{
                if (booly) {
                    return;
                }
                $(zone1).val($(zone1).val() + sym);
                Symbol = sym; Num = parseFloat($(zone2).val());
                ClearZone(zone2, "0");
            }
            booly = true;
        }

        $(".s12").bind({
            click: function(){
                SymbolClick(".Val3", ".Val4", '+');
            }
        });

        $(".s22").bind({
            click: function(){
                SymbolClick(".Val3", ".Val4", '-');
            }
        });

        $(".s32").bind({
            click: function(){
                SymbolClick(".Val3", ".Val4", 'x');
            }
        });

        $(".s42").bind({
            click: function(){
                SymbolClick(".Val3", ".Val4", '/');
            }
        });

        $(".s52").bind({
            click: function(){
                SymbolClick(".Val3", ".Val4", '%');
            }
        });

        $(".s62").bind({
            click: function(){
                if ($(".Val3").val() == "") {
                    return;
                }
                $(".Val3").val($(".Val3").val() + $(".Val4").val());
                Calcul(Num, $(".Val4").val(), ".Val3", ".Val4", Symbol, false);
                if (fautCalcul) {
                    ClearZone(".Val3", "");ClearZone(".Val4", "0");
                    fautCalcul=false;
                }
                booly = false;
            }
        });

        $(".p").css({
            "width": "45%",
            "height": "540px",
            "border": "none",
            "border-radius": "10px",
            "background-color": "#2196F3",
            "box-shadow": "0px 0px 10px 0px black",
            "margin": "90px auto",
            "padding-top": "20px",
            "position": "abbsolute",
            "display": "none"
        });

        $(".Valeurs3").css({
            "width": "94%",
            "height": "150px",
            "margin": "0px auto",
            "border": "none",
            "border-radius": "10px",
            "background-color": "white",
        });

        $(".Valeurs3 div").css({
            "width": "100%",
            "height": "75px",
            "text-align": "right",
        });

        $(".Valeurs3 input").css({
            "height": "30px",
            "width": "94%",
            "border": "none",
            "font-size": "17px",
            "font-weight": "bold",
            "text-align": "right",
            "margin-top": "25px",
            "margin-left": "1%",
            "margin-right": "2%",
            "padding": "0px 10px"
        });

        $(".Buttons3").css({
            "width": "100%",
            "height": "100%"
        });
    
        $(".Buttons3 div").css({
            "width": "95%",
            "height": "60px",
            "margin": "0px auto",
            "padding-top": "15px",
            "padding-left": "2%"
        });
    
        $(".Buttons3 button").css({
            "width": "15%",
            "height": "50px",
            "font-size": "15px",
            "font-weight": "bolder",
            "border": "none",
            "border-radius": "10px",
            "margin": "2px",
            "background-color": "white"
        });

        $(".Buttons3 button").on({
            mouseenter: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "#09E4FE"
                })
            },
            mousedown: function(){
                $(this).css({
                    "color": "white",
                    "background-color": "#44BFE6"
                })
            },
            mouseup: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "#09E4FE"
                })
            },
            mouseleave: function(){
                $(this).css({
                    "color": "black",
                    "background-color": "white"
                })
            }
        });

        WriteNumber(".n03", ".Val6", "0");
        WriteNumber(".n13", ".Val6", "1");
        WriteNumber(".n23", ".Val6", "2");
        WriteNumber(".n33", ".Val6", "3");
        WriteNumber(".n43", ".Val6", "4");
        WriteNumber(".n53", ".Val6", "5");
        WriteNumber(".n63", ".Val6", "6");
        WriteNumber(".n73", ".Val6", "7");
        WriteNumber(".n83", ".Val6", "8");
        WriteNumber(".n93", ".Val6", "9");
        WriteNumber(".nA3", ".Val6", "A");
        WriteNumber(".nB3", ".Val6", "B");
        WriteNumber(".nC3", ".Val6", "C");
        WriteNumber(".nD3", ".Val6", "D");
        WriteNumber(".nE3", ".Val6", "E");
        WriteNumber(".nF3", ".Val6", "F");

        $(".c3").bind({
            click: function(){
                ClearZone(".Val5", "");ClearZone(".Val6", "0");
                NumOpen = 0; NumClose = 0; Symbol = '';
            }
        });

        $(".ce3").bind({
            click: function(){
                ClearZone(".Val6", "0");
            }
        });

        $(".bs3").bind({
            click: function(){
                BackSpace(".Val6");
            }
        });

        $(".open3").bind({
            click: function(){
                if (NumOpen == 25) {
                    return;
                }
                $(".Val5").val('(' + $(".Val5").val());
                NumOpen += 1;
            }
        });

        $(".close3").bind({
            click: function(){
                if (NumClose == NumOpen) {
                    return;
                }
                if ($(".Val5").val().includes($(".Val6").val())) {
                    $(".Val5").val($(".Val5").val() + ')');
                }else{
                    $(".Val5").val($(".Val5").val() + $(".Val6").val() + ')');
                }
                NumClose += 1;
            }
        });
    });