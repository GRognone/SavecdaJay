
// const constante =""; /* valeur non modifiable */
// var variable1;/* a une portee dans toute la fonction */
// let variable2; /*utiliser en préférence*/ 

// Télécharger une ressource dist ante

// option 1 fonctionne sur des evennements
//let xhr = new XMLHttpRequest();

// option 2 foctionne sur des promesses
//utiliser l'API fecth de JavaScript

// 1ere solution de codage fetch

/*fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json')
.then(function(response) {
    return response.json();
})
.then(function(json){
console.log(json);//affiche les données dans la console
}) */


//2eme solution de codage fetch

// 1ere solution de codage fetch.v2( peu ou plus utilisé)

/*fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json')
.then(response => response.json()) // est directement un return
.then(function(json){
    console.log(json)
})
.catch(function(error) {
    // traitement des exceptions(error)
});*/

// ajouts des évènements de l'interface utilisateur 

let zipcodeInput = document.getElementById('zipcode');
console.log(zipcodeInput); // affiche l'element dans la console
console.log(zipcodeInput.name); // affiche un attribut de l'élément

zipcodeInput.addEventListener('keyup', (event) => {
    var reg = new RegExp('^[0-9]{5}$'); //regex de contrôle
    let value = event.target.value; // event.target  = element qui a déclenché l'evenement

    if(reg.test(value)){
        console.log(value);
        // rechercher si le code postal existe
        zipcodes.search(value);
        console.log(zipcodes);
    }

});

class ZipCode
{
    constructor()
    {
        this.datasource = "https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
        this.zipcodes = [];
    }

    async load() {
        //2eme solution de codage fetch.v2
        try{
            let response = await fetch(this.datasource);
            this.zipcodes = await response.json();
            console.log(this.zipcodes);// recupère un tableau de données
            console.log(this.zipcodes[0]) // prends 1 objet de la collection
        } catch(error){
            //traitement de l'erreur
        }
    }

    search(zipcode)
    {
        let result = [];
        
/* correspond à l'utilisation de la commande filter en dessous
        for(let city of this.zipcodes){
            if(city.codePostal == zipcode){
                result.push(city);
                console.log(result);
            }
        }
*/
        result = this.zipcodes.filter(city => city.codePostal == zipcode);
        console.log(result);
    }
}
 
const zipcodes = new ZipCode();
zipcodes.load();
