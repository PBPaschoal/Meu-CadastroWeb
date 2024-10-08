// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.querySelector('.login-form').addEventListener('submit', function (event) {
    const birthDate = document.getElementById('dataNascimento').value;
    const year = new Date(birthDate).getFullYear();

    if (year.toString().length !== 4 || year > new Date().getFullYear() || year < 1900) {
        alert("Por favor, insira uma data de nascimento válida.");
        event.preventDefault(); // Impede o envio do formulário
    }
});
