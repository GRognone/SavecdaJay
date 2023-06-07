/*
{"id":1,
"name":"Ricko",
"level":1,
"power":7,
"attack":11,
"armor":6,
"damage":1845,
"mitigation":18,
"played":499546,
"victory":320499,
"defeat":166596,
 "draw":12451}
*/ 
class Card
{
    constructor(card)
    {
       Object.assign(this,card)
       //console.log(this)
    }

    /** retourne les valeurs de l'objet courant dans le tableau
    *@returns {Array} les valeurs de l'objet courant
    
    */
    getValues()
    {
       return Object.values(this)
    }

    /** retourne les noms des attributs de l'objet courant
     * @returns {array} les attributs de l'objet courant
    */
    getKeys()
    {
        return Object.keys(this)
    }
}
export { Card };