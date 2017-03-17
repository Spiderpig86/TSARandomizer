// Super complex TSA deep learning randomizer.

let img = document.getElementById('arrow');
let lastUpd = document.getElementById('lastUpdate');

img.addEventListener('click', () => {
    img.src = (Math.floor(Math.random() * 2) > 0 ? 'img/angle-right.svg' : 'img/angle-left.svg');
    lastUpd.innerText = 'Last Updated: ' + dateFormat(new Date(),'dddd, mmmm dS, yyyy, h:MM:ss TT');
});