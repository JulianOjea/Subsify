package com.example.subsify.Activities;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.example.subsify.R;
import com.example.subsify.Util.Request;
import com.example.subsify.Util.SubscriptionRow;

import java.util.List;

public class UserHomeActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_home);

        Button btnRequest = findViewById(R.id.bttn_test);
        btnRequest.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Request request = new Request();
                List<SubscriptionRow> sr = request.makeApiRequest();
                Log.d("ey", "ey");
            }
        });

        System.out.println("hey");
    }

}