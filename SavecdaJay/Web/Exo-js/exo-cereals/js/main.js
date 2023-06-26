import{ Cereals } from "./cereals.js";
import { Table } from "./table.js";

let cereal = new Cereals();
await cereal.getCereals();
console.log(cereal.cerealsCollection)
let cerealTable = new Table(cereal);
cerealTable.generateBody();

document.getElementById("id").addEventListener("click",(e) => {cerealTable.generateBody(cereal.sortCerealById())})
document.getElementById("nom").addEventListener("click",(e)=> {cerealTable.generateBody(cereal.sortCerealByName())});
document.getElementById("calories").addEventListener("click",(e)=> {cerealTable.generateBody(cereal.sortCerealByCalories())});
document.getElementById("proteines").addEventListener("click",(e) => {cerealTable.generateBody(cereal.sortCerealByProteins())})
document.getElementById("sel").addEventListener("click",(e) => {cerealTable.generateBody(cereal.sortCerealBySodiums())})
document.getElementById("fibres").addEventListener("click",(e) => {cerealTable.generateBody(cereal.sortCerealByFibers())})
document.getElementById("glucides").addEventListener("click",(e) => {cerealTable.generateBody(cereal.sortCerealByCarbos())})
document.getElementById("sucres").addEventListener("click",(e) => {cerealTable.generateBody(cereal.sortCerealBySugars())})
document.getElementById("potassium").addEventListener("click",(e)=> {cerealTable.generateBody(cereal.sortCerealByPotass())});
document.getElementById("vitamines").addEventListener("click",(e)=> {cerealTable.generateBody(cereal.sortCerealByVitamins())});
document.getElementById("evaluation").addEventListener("click",(e)=> {cerealTable.generateBody(cereal.sortCerealByRatings())});
document.getElementById("ns").addEventListener("click",(e)=> {cerealTable.generateBody(cereal.sortCerealByRatings())});
