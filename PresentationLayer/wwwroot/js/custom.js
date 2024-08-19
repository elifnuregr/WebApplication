document.addEventListener("DOMContentLoaded", function () {
    // Hata mesajı elementini seç
    var errorMessage = document.getElementById("error-message");

    // Eğer hata mesajı mevcutsa 3 saniye sonra gizle
    if (errorMessage && errorMessage.innerHTML.trim() !== "") {
        setTimeout(function () {
            errorMessage.style.transition = "opacity 0.5s ease";
            errorMessage.style.opacity = "0";
            setTimeout(function () {
                errorMessage.style.display = "none";
            }, 500);
        }, 3000);
    }
});
