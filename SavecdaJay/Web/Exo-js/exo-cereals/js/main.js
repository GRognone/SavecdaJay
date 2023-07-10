import{ Cereals } from "./cereals.js";
import { Table } from "./table.js";
import { CerealEvent } from "./cerealEvent.js";
import { Cereal } from "./cereal.js";

let cereal = new Cereals();
CerealEvent.cereals=cereal;
await cereal.getCereals();
let cerealTable = new Table(cereal);
cerealTable.generateTable();


document.getElementById("id").addEventListener("click",(e) => {cerealTable.generateTable(cereal.sortCerealById())});
document.getElementById("nom").addEventListener("click",(e)=> {cerealTable.generateTable(cereal.sortCerealByName())});
document.getElementById("calories").addEventListener("click",(e)=> {cerealTable.generateTable(cereal.sortCerealByCalories())});
document.getElementById("proteines").addEventListener("click",(e) => {cerealTable.generateTable(cereal.sortCerealByProteins())});
document.getElementById("sel").addEventListener("click",(e) => {cerealTable.generateTable(cereal.sortCerealBySodiums())});
document.getElementById("fibres").addEventListener("click",(e) => {cerealTable.generateTable(cereal.sortCerealByFibers())});
document.getElementById("glucides").addEventListener("click",(e) => {cerealTable.generateTable(cereal.sortCerealByCarbos())});
document.getElementById("sucres").addEventListener("click",(e) => {cerealTable.generateTable(cereal.sortCerealBySugars())});
document.getElementById("potassium").addEventListener("click",(e)=> {cerealTable.generateTable(cereal.sortCerealByPotass())});
document.getElementById("vitamines").addEventListener("click",(e)=> {cerealTable.generateTable(cereal.sortCerealByVitamins())});
document.getElementById("evaluation").addEventListener("click",(e)=> {cerealTable.generateTable(cereal.sortCerealByRatings())});
document.getElementById("ns").addEventListener("click",(e)=> {cerealTable.generateTable(cereal.sortCerealByRatings())});


/* utilisation des filtres*/

let inputSearch = document.getElementById("cerealSearch");
let categoriesSelect = document.getElementById("categorieSelect")
let inputList = document.querySelectorAll('#nutriscore input[type="checkbox"]');

Cereals.updateFilter = () =>
{
    let letters =[]; 
    inputList.forEach(c=>{
        if(c.checked){
            letters.push(c.id);
        }
    });
    cereal.applyAllFilters(inputSearch.value, categoriesSelect.value, letters)
    cerealTable.generateTable();
}

inputSearch.addEventListener("input",Cereals.updateFilter);

categoriesSelect.addEventListener("change",Cereals.updateFilter);

inputList.forEach(i=>i.addEventListener("click",Cereals.updateFilter));



