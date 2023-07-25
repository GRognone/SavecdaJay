import { MesElementsDuGlossaire } from "./elementsGlossaire.js"

let elementGlossaire = new MesElementsDuGlossaire();
await elementGlossaire.loadData();
let elementsDuGlossaire = document.getElementById("scrollBar"); 

generateDropList()
{
    this.elementsDuGlossaire.innerHTML="";
    let option = document.createElement('option')
    elementsDuGlossaire.appendChild(option);
    for(let ele of this.elementGlossaire.mesElementsGlossaire)
    {
        option.textContent = ele
        console.log('option');
    }
}