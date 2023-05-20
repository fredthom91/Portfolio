const showOnPx = 100;
const backToTopButton = document.querySelector(".totop-arrow")

const scrollContainer = () => {
    return document.documentElement || document.body;
};

document.addEventListener("scroll", () => {
    if (scrollContainer().scrollTop > showOnPx) {
        backToTopButton.classList.remove("hidden")
    } else {
        backToTopButton.classList.add("hidden")
    }
})

const goToTop = () => {
    document.body.scrollIntoView();
};

backToTopButton.addEventListener("click", goToTop)


let slideIndex = 1;
showSlides(slideIndex);


function plusSlides(n) {
    showSlides(slideIndex += n);
}


function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}

function downloadFile() {
    var link = document.createElement("a");
    link.download = "document.pdf";
    link.href = "../CV/CVFredrik.pdf";
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}


function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
}


function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

