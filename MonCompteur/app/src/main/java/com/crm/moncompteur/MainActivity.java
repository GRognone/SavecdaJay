package com.crm.moncompteur;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
TextView t;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        t =(TextView) findViewById(R.id.textViewCompteur);
        t.setText("0");
        CharSequence s =t.getText();
        String ss= s.toString();
    }

    public void increment(View v) {
        int number = Integer.parseInt (t.getText().toString());
        number++;
        t.setText(number);



    }

    public void decrement(View v){

    }

    public void quit(View v){

    }


}