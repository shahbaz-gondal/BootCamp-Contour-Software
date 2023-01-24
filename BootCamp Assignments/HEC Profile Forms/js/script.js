// Showing Personl-Details Section, Started

function storedetails(){
    var title = document.getElementById("titled").value;
    var fname = document.getElementById("fname").value;
    var mname = document.getElementById("mname").value;
    var lname = document.getElementById("lname").value;
    if(mname != ""){
        var fullname = title+" "+fname+" "+mname+" "+lname;
    }
    else{
        var fullname = title+" "+fname+" "+lname;
    }
    document.getElementById("fullnameBio").innerHTML = fullname;
    var ms1 = document.getElementById("ms1");
    var ms2 = document.getElementById("ms2");
    var ms3 = document.getElementById("ms3");
    var ms4 = document.getElementById("ms4");
    if(ms1.checked==true){
        var maritalstatus = ms1.value;
    }
    else if(ms2.checked==true){
        var maritalstatus = ms2.value;
    }
    else if(ms3.checked==true){
        var maritalstatus = ms3.value;
    }
    else if(ms4.checked==true){
        var maritalstatus = ms4.value;
    }
    document.getElementById("maritalstatusBio").innerHTML = maritalstatus;
    var g1 = document.getElementById("g1");
    var g2 = document.getElementById("g2");
    var g3 = document.getElementById("g3");
    if(g1.checked == true){
        var gender = g1.value;
    }
    else if(g2.checked == true){
        var gender = g2.value;
    }
    else if(g3.checked == true){
        var gender = g3.value;
    }
    document.getElementById("genderBio").innerHTML = gender;
    document.getElementById("religionBio").innerHTML = document.getElementById("religion").value;
    document.getElementById("dateofbirthBio").innerHTML = document.getElementById("date").value;
    document.getElementById("ageBio").innerHTML = document.getElementById("totalage").value;
    document.getElementById("countryBio").innerHTML = document.getElementById("country").value;
    document.getElementById("provinceBio").innerHTML = document.getElementById("province").value;
    document.getElementById("districtBio").innerHTML = document.getElementById("district").value;
    document.getElementById("cityBio").innerHTML = document.getElementById("city").value;
    document.getElementById("CNICBio").innerHTML = document.getElementById("cnic").value;
    document.getElementById("fatherBio").innerHTML = document.getElementById("fathername").value;
}

// Showing Personl-Details Section, Ended

// Showing Contact-Details Section, Started

function storecontact(){
    document.getElementById("cellphoneBio").innerHTML = document.getElementById("cellphone").value;
    document.getElementById("emailBio").innerHTML = document.getElementById("email").value;
    document.getElementById("mailingaddressBio").innerHTML = document.getElementById("mailingaddress").value;
    document.getElementById("sociallinkBio").innerHTML = document.getElementById("sociallink").value;
    
}

// Showing Contact-Details Section, Ended

// Showing Education-Details Section, Started

function storeeducation(){
    document.getElementById("qlevelBio").innerHTML = document.getElementById("qlevel").value;
    document.getElementById("degreeBio").innerHTML = document.getElementById("degree").value;
    document.getElementById("universityBio").innerHTML = document.getElementById("university").value;
    var gs1 = document.getElementById("gs1");
    var gs2 = document.getElementById("gs2");
    var gs3 = document.getElementById("gs3");
    if(gs1.checked == true){
        var gradingsystem = gs1.value;
    }
    else if(gs2.checked == true){
        var gradingsystem = gs2.value;
    }
    else if(gs3.checked == true){
        var gradingsystem = gs3.value;
    }
    document.getElementById("gradingsystemBio").innerHTML = gradingsystem;
    document.getElementById("totalBio").innerHTML = document.getElementById("total").value;
    document.getElementById("obtainedBio").innerHTML = document.getElementById("obtained").value;
}

// Showing Education-Details Section, Ended

// Showing Employment-Details Section, Started

function storeemployment(){
    var ot1 = document.getElementById("ot1");
    var ot2 = document.getElementById("ot2");
    if(ot1.checked == true){
        var orgtype = ot1.value;
    }
    else if(ot2.checked == true){
        var orgtype = ot2.value;
    }
    document.getElementById("orgtypeBio").innerHTML = orgtype;
    document.getElementById("orgnameBio").innerHTML = document.getElementById("email").value;
    document.getElementById("jobBio").innerHTML = document.getElementById("job").value;
    document.getElementById("levelBio").innerHTML = document.getElementById("level").value;
    document.getElementById("empcountryBio").innerHTML = document.getElementById("empcountry").value;
    document.getElementById("empcityBio").innerHTML = document.getElementById("empcity").value;
    document.getElementById("empaddressBio").innerHTML = document.getElementById("empaddress").value;
}

// Showing Employment-Details Section, Ended

//Setting of Previous and Next Button Started
$(document).ready(function(){
    $("#details").siblings().removeClass('active');
    $("#details").addClass("active");
    $("#detstab").css({"background-color":"white", "border-top":"2px solid green"});
});

$(document).ready(function(){
    $(".nav li").click(function(){
        $(this).siblings().removeClass('active');
        $(this).addClass('active');
        $(this).siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $(this).css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnNextc").click(function(){
        $("#contact").siblings().removeClass('active');
        $("#contact").addClass("active");
        $("#contab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#contab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnNexted").click(function(){
        $("#education").siblings().removeClass('active');
        $("#education").addClass("active");
        $("#edutab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#edutab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnNextem").click(function(){
        $("#employment").siblings().removeClass('active');
        $("#employment").addClass("active");
        $("#emtab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#emtab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnNextbio").click(function(){
        $("#bio").siblings().removeClass('active');
        $("#bio").addClass("active");
        $("#biotab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#biotab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnPred").click(function(){
        $("#details").siblings().removeClass('active');
        $("#details").addClass("active");
        $("#detstab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#detstab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnPrec").click(function(){
        $("#contact").siblings().removeClass('active');
        $("#contact").addClass("active");
        $("#contab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#contab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnPreed").click(function(){
        $("#education").siblings().removeClass('active');
        $("#education").addClass("active");
        $("#edutab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#edutab").css({"background-color":"white", "border-top":"2px solid green"});
    });
    $("#btnPreem").click(function(){
        $("#employment").siblings().removeClass('active');
        $("#employment").addClass("active");
        $("#emtab").siblings().css({"background-color":"lightgray", "border-top":"1px solid lightgray"});
        $("#emtab").css({"background-color":"white", "border-top":"2px solid green"});
    });
});

//Setting of Previous and Next button Ended

// Age Calculation Section, Started

function month30(todaymonth, bmonth, day1, todaydate){
    if(eval(day1 + todaydate) == 30 ){
        var totalmonths = eval(todaymonth-bmonth);
        document.getElementById("totalage").value = totalmonths+" Months";
    }
    else if( eval(day1 + todaydate) < 30 ){
        var totalmonths = eval(todaymonth-1-bmonth);
        var totaldays = eval(day1+todaydate);
        document.getElementById("totalage").value = totalmonths+" Months and "+totaldays+" Days";
    }
    else{
        var totalmonths = eval(todaymonth-bmonth);
        var totaldays = eval((day1+todaydate) - 30);
        document.getElementById("totalage").value = totalmonths+" Months and "+totaldays+" Days";
    }
}
function month31(todaymonth, bmonth, day1, todaydate){
    if(eval(day1 + todaydate) == 31 ){
        var totalmonths = eval(todaymonth-bmonth);
        document.getElementById("totalage").value = totalmonths+" Months";
    }
    else if(eval(day1 + todaydate) < 31 ){
        var totalmonths = eval(todaymonth-1-bmonth);
        var totaldays = eval(day1+todaydate);
        document.getElementById("totalage").value = totalmonths+" Months and "+totaldays+" Days";
    }
    else{
        var totalmonths = eval(todaymonth-bmonth);
        var totaldays = eval((day1+todaydate) - 31);
        document.getElementById("totalage").value = totalmonths+" Months and "+totaldays+" Days";
    }
}
function lesstodaydate(bmonth, bdate, todaydate, totalyears, totalmonths){
    if(bmonth < 8 && eval(bmonth%2)==0 && bmonth!=2){
        var day1 = eval(30-bdate);
    }
    else if(bmonth < 8 && eval(bmonth%2)!=0 && bmonth!=2){
        var day1 = eval(31-bdate);
    }
    else if(bmonth >= 8 && eval(bmonth%2)==0){
        var day1 = eval(31-bdate);
    }
    else if(bmonth >= 8 && eval(bmonth%2)!=0){
        var day1 = eval(30-bdate);
    }
    else if(bmonth==2 && eval(eval(byear%4)!=0)){
        var day1 = eval(28-bdate);
    }
    else if(bmonth==2 && eval(byear%4)==0){
        var day1 = eval(29-bdate);
    }
    var totaldays = eval(todaydate+day1);
    document.getElementById("totalage").value = totalyears+" Years "+totalmonths+" Months "+totaldays+" Days";
}
function age(){
    const birthdate = document.getElementById("date").value;
    let byear = Number(birthdate.slice(0,4));
    let bmonth = Number(birthdate.slice(5,7));
    let bdate = Number(birthdate.slice(8,10));
    const date = new Date();
    let todaymonth = Number(date.getMonth()+1);
    let todaydate = Number(date.getDate());
    let todayyear = Number(date.getFullYear());
    
    if(birthdate != ""){
        if(todayyear < byear){
            document.getElementById("totalage").style.color = "red";
            document.getElementById("totalage").style.border = "1px solid red";
            document.getElementById("date").style.border = "1px solid red";
            document.getElementById("totalage").value = "invalid year";
        }
        else if(todayyear == byear){
            if(todaymonth < bmonth){
                document.getElementById("totalage").style.color = "red";
                document.getElementById("totalage").style.border = "1px solid red";
                document.getElementById("date").style.border = "1px solid red";
                document.getElementById("totalage").value = "invalid month";
            }
            else if(todaymonth == bmonth){
                if(todaydate < bdate){
                    document.getElementById("totalage").style.color = "red";
                    document.getElementById("totalage").style.border = "1px solid red";
                    document.getElementById("date").style.border = "1px solid red";
                    document.getElementById("totalage").value = "invalid date";
                }
                else if(todaydate == bdate){
                    document.getElementById("totalage").style.color = "darkgreen";
                    document.getElementById("totalage").style.border = "1px solid green";
                    document.getElementById("date").style.border = "1px solid black";
                    document.getElementById("totalage").value = "Happy Birthday, Welcome to this world";
                }
                else if(todaydate > bdate){
                    document.getElementById("totalage").style.color = "darkgreen";
                    document.getElementById("totalage").style.border = "1px solid green";
                    document.getElementById("date").style.border = "1px solid black";
                    var day1 = eval(todaydate - bdate);
                    if(day1 > 1){
                        document.getElementById("totalage").value =day1 + " Days";
                    }
                    else{
                        document.getElementById("totalage").value =day1 + " Day";
                    }
                }
            }
            else if(todaymonth > bmonth){
                document.getElementById("totalage").style.color = "darkgreen";
                document.getElementById("totalage").style.border = "1px solid green";
                document.getElementById("date").style.border = "1px solid black";
                    if(bmonth < 8 && bmonth > 1 && eval(bmonth%2==0)){
                        var day1 = eval(30-bdate);
                        month30(todaymonth, bmonth, day1, todaydate);
                    }
                    else if(bmonth < 8 && todaymonth != 2 && eval(bmonth%2!=0)){
                        var day1 = eval(31-bdate);
                        month31(todaymonth, bmonth, day1, todaydate);
                    }
                    else if(bmonth >= 8 && eval(bmonth%2==0)){
                        var day1 = eval(31-bdate);
                        month31(todaymonth, bmonth, day1, todaydate);
                    }
                    else if(bmonth >= 8 && eval(bmonth%2!=0)){
                        var day1 = eval(30-bdate);
                        month30(todaymonth, bmonth, day1, todaydate);
                    }
                    else if(todaymonth == 2){
                        var day1 = eval(31-bdate);
                        if((todayyear%4)!=0){
                            if(todaydate=28){
                                document.getElementById("totalage").value = "1 Month " + day1 + "Days";
                            }
                            else if( todaydate < 28 ){
                                if(eval(day1+todaydate)>=31){
                                var totaldays = eval(eval(day1+todaydate)-31);
                                document.getElementById("totalage").value ="1 Months " + totaldays+" Days";
                                }
                                else if(eval(day1+todaydate)<31){
                                    var totaldays = eval(31 - eval(day1+todaydate));
                                    document.getElementById("totalage").value = totaldays+" Days";
                                }
                            }
                        }
                        else{
                            if(todaydate=29){
                                document.getElementById("totalage").value = "1 Month " + day1 + "Days";
                            }
                            else if( todaydate < 29 ){
                                if(eval(day1+todaydate)>=31){
                                var totaldays = eval(eval(day1+todaydate)-31);
                                document.getElementById("totalage").value ="1 Months " + totaldays+" Days";
                                }
                                else if(eval(day1+todaydate)<31){
                                    var totaldays = eval(31 - eval(day1+todaydate));
                                    document.getElementById("totalage").value = totaldays+" Days";
                                }
                            }
                        }
                    }
            }
        }
        else if(todayyear > byear){
            document.getElementById("totalage").style.color = "darkgreen";
            document.getElementById("totalage").style.border = "1px solid green";
            document.getElementById("date").style.border = "1px solid black";
            if(todaymonth==bmonth){
                if(todaydate==bdate){
                    var totalyears = eval(todayyear - byear);
                    document.getElementById("totalage").value = totalyears+" Years, Happy_Birthday";
                }
                else if(todaydate>bdate){
                    var totaldays = eval(todaydate - bdate);
                    var totalyears = eval(todayyear - byear);
                    document.getElementById("totalage").value = totalyears+" Years and "+totaldays+" Days";
                }
                else{
                    var totalyears = eval(todayyear-1-byear);
                    var totalmonths = eval(todaymonth-1);
                    lesstodaydate(bmonth, bdate, todaydate, totalyears, totalmonths);
                }
            }
            if(todaymonth>bmonth){
                if(todaydate==bdate){
                    var totalyears = eval(todayyear-byear);
                    var totalmonths = eval(todaymonth-bmonth);
                    document.getElementById("totalage").value = totalyears+" Years "+totalmonths+" Months";
                }
                else if(todaydate>bdate){
                    var totalyears = eval(todayyear-byear);
                    var totalmonths = eval(todaymonth-bmonth);
                    var totaldays = eval(todaydate-bdate);
                    document.getElementById("totalage").value = totalyears+" Years "+totalmonths+" Months "+totaldays+" Days";
                }
                else{
                    var totalyears = eval(todayyear-byear);
                    var totalmonths = eval(todaymonth-1-bmonth);
                    lesstodaydate(bmonth, bdate, todaydate, totalyears, totalmonths);
                }
            }
            if(todaymonth<bmonth){
                if(todaydate==bdate){
                    var totalyears = eval(todayyear-1-byear);
                    var month1 = eval(12-bmonth);
                    var totalmonths = eval(month1+todaymonth);
                    document.getElementById("totalage").value = totalyears+" Years "+totalmonths+" Months";
                }
                else if(todaydate>bdate){
                    var totalyears = eval(todayyear-1-byear);
                    var month1 = eval(12-bmonth);
                    var totalmonths = eval(month1+todaymonth);
                    var totaldays = eval(todaydate-bdate);
                    document.getElementById("totalage").value = totalyears+" Years "+totalmonths+" Months "+totaldays+" Days";
                }
                else{
                    var totalyears = eval(todayyear-1-byear);
                    var month1 = eval(12-bmonth);
                    var totalmonths = eval(month1+todaymonth-1);
                    lesstodaydate(bmonth, bdate, todaydate, totalyears, totalmonths);
                }
            }
        }
    }
    else if(birthdate == ""){
        document.getElementById("totalage").style.border = "1px solid red";
        document.getElementById("totalage").style.color = "red";
        document.getElementById("date").style.border = "1px solid red";
        document.getElementById("totalage").value = "Please select Birthday Date";
    }
}

// Age Calculation Section, Ended