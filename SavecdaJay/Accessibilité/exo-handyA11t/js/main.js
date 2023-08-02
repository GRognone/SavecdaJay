import { MesElementsDuGlossaire } from "./elementsGlossaire.js"

let elementGlossaire = new MesElementsDuGlossaire();
await elementGlossaire.loadData();
let elementsDuGlossaire = document.getElementById("scrollBar"); 
console.log(elementsDuGlossaire);
generateDropList();

function generateDropList()
{
    elementsDuGlossaire.innerHTML="";
   
    for(let ele of elementGlossaire.mesElementsGlossaire)
    {
        let option = document.createElement('option')
        option.textContent = ele.titre;
        elementsDuGlossaire.appendChild(option);
    }
}