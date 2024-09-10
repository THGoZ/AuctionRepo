function initializeFilePond() {
    FilePond.create(document.querySelector)('.file-pond-input'), {};
}

window.initializeTooltips = () => {
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl));
}

function setImageSrc(base64Image) {
    document.getElementById('imageResult').src = base64Image;
}

/*  ==========================================
    SHOW UPLOADED IMAGE
* ========================================== */
function readURL(file) {
    var reader = new FileReader();

    reader.onload = function (e) {
        document.getElementById('imageResult').src = e.target.result;
    };
    reader.readAsDataURL(file);
}

$(function () {
    $('#upload').on('change', function () {
        readURL(input);
    });
});

/*  ==========================================
    SHOW UPLOADED IMAGE NAME
* ========================================== */
var input = document.getElementById('upload');
var infoArea = document.getElementById('upload-label');

input.addEventListener('change', showFileName);
function showFileName(event) {
    var input = event.srcElement;
    var fileName = input.files[0].name;
    infoArea.textContent = 'File name: ' + fileName;
}