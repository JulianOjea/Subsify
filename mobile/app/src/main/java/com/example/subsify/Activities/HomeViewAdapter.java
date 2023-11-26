package com.example.subsify.Activities;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.icu.text.SimpleDateFormat;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.subsify.R;
import com.example.subsify.Util.SubscriptionRow;

import java.time.LocalDate;
import java.time.ZoneId;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;
import java.util.Locale;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class HomeViewAdapter extends RecyclerView.Adapter<HomeViewAdapter.ViewHolder>{
    private List<SubscriptionRow> subscriptionList = new ArrayList<>();
    public void updateList(List<SubscriptionRow> nuevosDatos) {
        subscriptionList.clear();
        subscriptionList.addAll(nuevosDatos);
        notifyDataSetChanged();
    }
    @NonNull
    @Override
    public HomeViewAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.card_layout, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull HomeViewAdapter.ViewHolder holder, int position) {
        SubscriptionRow subscriptionRow = subscriptionList.get(position);
        TextView tituloTextView = holder.itemView.findViewById(R.id.platf_name);
        tituloTextView.setText(subscriptionRow.getPlatfName());

        byte[] platfImageBytes = subscriptionRow.getPlatfImageBytes();
        Bitmap bitmap = BitmapFactory.decodeByteArray(platfImageBytes, 0, platfImageBytes.length);
        ImageView imageView = holder.itemView.findViewById(R.id.platf_image);
        imageView.setImageBitmap(bitmap);

        Date subLapseEnd = addOneDay(subscriptionRow.getSubLapseEndDate());
        SimpleDateFormat sdf = new SimpleDateFormat("d MMM yyyy", Locale.getDefault());
        TextView subLapseEndTextView = holder.itemView.findViewById(R.id.sub_lapse_end);
        subLapseEndTextView.setText("Termina el " + sdf.format(subLapseEnd));

        Date now = new Date();
        LocalDate localDateSubLapseEnd = subLapseEnd.toInstant().atZone(ZoneId.systemDefault()).toLocalDate();
        LocalDate localDateNow = now.toInstant().atZone(ZoneId.systemDefault()).toLocalDate();

        long differenceInDays = java.time.temporal.ChronoUnit.DAYS.between(localDateNow, localDateSubLapseEnd);
        TextView daysDiff = holder.itemView.findViewById(R.id.renew_days);
        daysDiff.setText("Se renueva en " + differenceInDays + " días");
    }

    @Override
    public int getItemCount() {
        return subscriptionList.size();
    }

    public static class ViewHolder extends RecyclerView.ViewHolder {

        public ViewHolder(View itemView) {
            super(itemView);
        }
    }

    private Date addOneDay(Date subLapseEnd){
        Calendar calendar = Calendar.getInstance();
        calendar.setTime(subLapseEnd);
        calendar.add(Calendar.DAY_OF_MONTH, 1);
        return calendar.getTime();
    }
}
