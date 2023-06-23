import React from "react";
import Link from "next/link";
export default class Test extends React.Component {
    render(){
        return (
            <React.Fragment>
                <Link href="/pokemon">
                    Lien vers pokemon
                </Link>
                <br/>
                <Link href="/pokemon/liste">
                    Lien vers pokemon/Liste
                </Link>
            </React.Fragment>
          );
    }
}