
import { ZipCode } from './ZipCode.js';

// ajouts des évènements de l'interface utilisateur 

// Sélection de l'élémént HTML dont l'Id est égale à "ZipCode"
let zipcodeInput = document.getElementById('zipcode');
const zipcodes = new ZipCode();
zipcodes.load();

console.log(zipcodeInput); // affiche l'element dans la console
console.log(zipcodeInput.name); // affiche un attribut de l'élément


// creation d'un evenement
zipcodeInput.addEventListener('keyup', (event) => {
    var reg = new RegExp('^[0-9]{5}$'); //regex de contrôle
    let value = event.target.value; // event.target  = element qui a déclenché l'evenement

    if(reg.test(value)){
        console.log(value);
        // rechercher si le code postal existe
        zipcodes.search(value);// appel de la methode "search" de la clase ZipCode
        console.log(zipcodes);
    }

});