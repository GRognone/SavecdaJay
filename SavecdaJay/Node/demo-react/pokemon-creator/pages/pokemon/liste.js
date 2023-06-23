import React from 'react';
import Image from 'next/image';
import Test from "../../public/Test"
export default class PokemeonListe extends React.Component
{
    render(){
        return(
            <div>
                <Test/>
                <h1>Liste des Pokemons</h1>
                <Image src="/images/pikachu.png" width={320} height={520} alt="photo de Pikachu"></Image>
            </div>
         );
    }
}

/* export default function pokemonListe(){
    return(
        <h1>Liste des Pokemons</h1>
     );
 }*/