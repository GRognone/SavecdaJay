import{ Cereals } from "./cereals.js";
import { Table } from "./table.js";
import { CerealEvent } from "./cerealEvent.js";

let cereal = new Cereals();
await cereal.getCereals();
console.log(cereal.cerealsCollection)
let cerealTable = new Table(cereal);
cerealTable.generateTable();
CerealEvent.cereals=cereal;

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

/*recherche*/
document.getElementById("cerealSearch").addEventListener("input",(e)=>{cerealTable.generateTable(CerealEvent.searchCereals(e.target.value))});
    
// /*tri par catégorie*/
// document.getElementById("categorieSelect").addEventListener("change",(e)=>{CerealEvent.sortCategory(e.target.value)});

// /*tri par nutriscore*/    
// document.getElementById("nutriscore").addEventListener('#nutriscore');


//programmation des filtres.
// let head=document.querySelectorAll(".keys");

// for(let h of head){
//     h.addEventListener("click",(e)=>{
//         cerealEvent.columnSortEvent(e);
//         cerealTable.generateTable();
//     })
// }
// let inputSearch =document.getElementById("cerealSearch");
// let categoriesSelect = document.getElementById("categorieSelect")
// let inputList = document.querySelectorAll('#nutriscore input[type="checkbox"]')

// Cereals.updateFilter = ()=>
// {
//     let letters =[];
//      inputList.foreach(c=>{
//         if(c.checked){
//             letters.push(c.id)
//         }
//     });
//  }
//  cereals.applyAllFilters(inputSearch.value, categoriesSelect.value, letters)
//  cerealTable.generateTable();

//  inputSearch.addEventListener("input", Cereals.updateFilter);
//  categoriesSelect.addEventListener("change",Cereals.updateFilter);
//  inputList.foreach(i=>i.addeventListener("click",Cereals.updateFilter));




