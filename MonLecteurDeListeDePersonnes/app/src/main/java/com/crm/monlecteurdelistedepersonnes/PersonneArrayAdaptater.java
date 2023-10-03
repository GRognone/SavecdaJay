package com.crm.monlecteurdelistedepersonnes;


import android.content.Context;
import android.util.DisplayMetrics;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.crm.classesdomaines.Personne;

import java.util.ArrayList;

public class PersonneArrayAdaptater extends ArrayAdapter<Personne> {
    private ArrayList<Personne> listPersonne;

    public PersonneArrayAdaptater(Context context, ArrayList<Personne> personnes) {

        super(context, R.layout.activity_layout_with_picture, personnes);
        listPersonne = personnes;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup){
        View v = view;
        if (view == null){
            LayoutInflater li = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            v= li.inflate(R.layout.activity_layout_with_picture, null);
        }

        Personne personneOfItem = (Personne) listPersonne.get(i);
        if(personneOfItem != null) {
            TextView nomView = (TextView) v.findViewById(R.id.textViewNom);
            TextView prenomView = (TextView) v.findViewById(R.id.textViewPrenom);
            ImageView photoView = (ImageView) v.findViewById(R.id.imageViewPhoto);

            if(nomView!=null){
                nomView.setText("Nom: " +personneOfItem.getNom());
            }
            if(prenomView!=null){
                prenomView.setText("Prenom: " +personneOfItem.getPrenom());
            }
            if(photoView!=null){
                if (personneOfItem.getDrawable() != null){
                    photoView.setImageDrawable(personneOfItem.getDrawable());
                }
                //si on a pas d'image par defaut il se servira de l'image demandé ici furby2
                else {
                    photoView.setImageDrawable(v.getResources().getDrawableForDensity(R.drawable.furby2, DisplayMetrics.DENSITY_XHIGH));
                }
            }
        }


        //
        return v;



    }
}
