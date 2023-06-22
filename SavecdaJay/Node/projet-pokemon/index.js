console.log('toto');

const pokemon = require ('pokemon');
// ou  import pokemon from 'pokemon' au choix l'un ou l'autre mais pas les 2.

const collection = pokemon.all('fr');

for(let pok of collection){
    console.log(pok);
}