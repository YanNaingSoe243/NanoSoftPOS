function NavBottom(itembar) {

    var btns = itembar.getElementsByClassName("nav-link");

    for (var i = 0; i < btns.length; i++) {

        btns[i].addEventListener("click", function () {
            var current = document.getElementsByClassName("Current");
            current[0].className = current[0].className.replace("Current", "");
            this.className = "nav-link Current";
        }

        );

        //if (document.location.href.indexOf(btns[i].href) >= 0) {
        //    btns[i].className = 'nav-link Curent';
        //}
        //else {
        //    btns[i].className = 'nav-link';
        //}

    }
    return true;

}

function Paging(itembar,PageCount) {

    var btns = itembar.getElementsByClassName("nav-lin");

    for (var i = 0; i < btns.length; i++) {

        btns[i].addEventListener("click", function () {
            var current = document.getElementsByClassName("active");
            current[0].className = current[0].className.replace("active", "");
            this.className = "nav-link active";
        }

        );

       
    }
    return true;

}
function Toggle(mysidebar, Main,hidden) {

    var btns = mysidebar.getElementsByClassName("Brand");
    if (hidden == false) {
        mysidebar.style.width = "0";
        Main.style.marginLeft = "0";
       
            
        
    }
    else {
       
        mysidebar.style.width = "240px";
        Main.style.marginLeft = "242px";
        
       
       
    }
    return true;

}

//function UpDown(container)
//{
//    if (container.getElementsByTagName("ul").style.display == "none") {
//        container.getElementsByTagName("ul").style.display == "block";
//    }
//    else {
//        container.getElementsByTagName("ul").style.display == "none";
//    }

        

//    return true;
//}


//window.saveAsFile = function (fileName, byteBase64) {
//    var link = this.document.createElement('a');
//    link.download = fileName;
//    link.href = "data:application/octet-stream;base64," + byteBase64;
//    this.document.body.appendChild(link);
//    link.click();
//    this.document.body.removeChild(link);
//    //alert("Downloaded");
//}
//function openNav() {
//    var x = document.getElementById("navDemo");
//    if (x.className.indexOf("w3-show") == -1) {
//        x.className += " w3-show";
//    } else {
//        x.className = x.className.replace(" w3-show", "");
//    }
//}

function cssclass(mysidebar) {



    var btns = mysidebar.getElementsByClassName("nav-link");

    for (var i = 0; i < btns.length; i++) {

        //btns[i].addEventListener("click", function () {
        //    var current = document.getElementsByClassName("active");
        //    current[0].className = current[0].className.replace("active", "");
        //    this.className = "nav-link active";
        //}

        //);


    }
   
    return true;

}
