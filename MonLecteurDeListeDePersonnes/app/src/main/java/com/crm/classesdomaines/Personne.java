package com.crm.classesdomaines;

import android.graphics.drawable.Drawable;
import android.media.Image;

public class Personne {
    private String nom;
    private String prenom;

    private Drawable drawable;

    public String getNom(){
        return nom;
    }

    public String getPrenom(){
        return prenom;
    }
    public Drawable getDrawable(){
        return drawable;
    }

    public Personne(String nom, String prenom){
        this.nom = nom;
        this.prenom = prenom;
    }

    public Personne(String nom, String prenom, Drawable drawable){
        this.nom = nom;
        this.prenom = prenom;
        this.drawable = drawable;
    }
}
