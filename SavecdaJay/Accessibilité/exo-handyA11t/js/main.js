import { MesElementsDuGlossaire } from "./elementsGlossaire.js"

let elementGlossaire = new MesElementsDuGlossaire();
await MesElementsDuGlossaire.loadData();

var titre = document.getElementById("titre");
    
    