import { Card } from "./Card.js";
import { Cards } from "./Cards.js";

const cards = new Cards('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
await cards.GetCards();

const myThead = document.getElementById("myThead");
const myTbody = document.getElementById("myTbody");
const myTfoot = document.getElementById('myTfoot');

function createTable()
{
    for(let card of cards.cardsCollection)
    {
         /* creer une ligne pour le tableau */
         let row = document.createElement('tr');

        for(let data of card.getValues())
        {
            /* ajoute une cellule pour le tableau */
            let cell = document.createElement('td');

            /* ajoute le nom de la carte à la cellule */
            cell.textContent = data;

            /* ajoute la cellule à la ligne */
            row.appendChild(cell);
        }
            /* ajoute la ligne à myTbody */
            myTbody.appendChild(row);
    }
    createTableHeader();
    createTableFooter();
 
}

/* Fonction pour creer une entête*/
function createTableHeader()
{
    let myCard = cards.getFirst();

    let row2 = document.createElement('tr');
    for(let data of myCard.getKeys())
    {
        // ajoute une cellule pour le tableau 
        let cell = document.createElement('th');

         //ajoute le nom de la carte à la cellule 
        cell.textContent = data;

         //ajoute la cellule à la ligne 
        row2.appendChild(cell);
     } 
    myThead.appendChild(row2);
}      

function createTableFooter()
{

    CreateTableRow(cards.getHigherArmorCard(),"Armor");
    CreateTableRow(cards.getHigherAttackCard(),"Attack");
    CreateTableRow(cards.getHigherPlayedCard(),"Most Played");
    CreateTableRow(cards.getHigherVictoryCard(),"Most Victory");
}

/**
 * 
 * @param {Card} card
 */
function CreateTableRow(card,dataType)
{
    let row = document.createElement('tr');
    let data = document.createElement('td');

    row.appendChild(data);
    data.textContent = dataType;
    data.colSpan = card.getValues().length;
    myTfoot.appendChild(data);

    let tr = document.createElement('tr');
    myTfoot.appendChild(tr);
    
    for(let data of card.getValues())
    {
        let cell = document.createElement('td');
        cell.textContent = data;
        tr.appendChild(cell);
    }
}
createTable();