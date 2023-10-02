package com.crm.moncompteur;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.res.Configuration;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    TextView t;
    public final String KEY_MonNombre="monnombre";
    public int monCurrentState;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        // Cette partie sert à charger la content view en fonction de l'orientation de l'appareil
        if (this.getResources().getConfiguration().orientation == Configuration.ORIENTATION_PORTRAIT){
            setContentView(R.layout.activity_main);
        } else if (this.getResources().getConfiguration().orientation == Configuration.ORIENTATION_LANDSCAPE){
            setContentView(R.layout.activity_main_landscape);
        }

        t =(TextView) findViewById(R.id.textViewCompteur);
        t.setText("0");
        CharSequence s =t.getText();
        String ss= s.toString();
        if (savedInstanceState!=null){
            int v = savedInstanceState.getInt(KEY_MonNombre);
            t.setText(String.valueOf(v));
        }
    }

    public void increment(View v) {
        int number = Integer.parseInt (t.getText().toString());
        number++;
        t.setText(String.valueOf(number));
    }

    public void decrement(View v){
       int number = Integer.parseInt(t.getText().toString());
        number--;
        t.setText(Integer.toString(number));
    }

    public void quit(View v){
        this.finish();
    }
    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState){
        super.onSaveInstanceState(outState);
        outState.putInt(KEY_MonNombre,Integer.parseInt(t.getText().toString()));
    }
}