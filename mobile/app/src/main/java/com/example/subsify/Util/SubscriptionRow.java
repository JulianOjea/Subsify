package com.example.subsify.Util;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import java.util.Date;

import com.google.gson.annotations.SerializedName;

public class SubscriptionRow {
    @SerializedName("PLATF_NAME")
    String platfName;
    @SerializedName("PLATF_IMAGE")
    byte[] platfImage;
    @SerializedName("SUB_LAPSE_END")
    double subLapseEnd;
    public String getPlatfName() {
        return platfName != null ? platfName.toString() : null;
    }
    public byte[] getPlatfImageBytes() {
        if (platfImage != null ) {
            return platfImage;
        }
        return null;
    }
    public Date getSubLapseEndDate() {
        return new Date((long) subLapseEnd);
    }
    public double getSubLapseEndDateDouble() {
        return subLapseEnd;
    }

//    public static class ImageData {
//        @SerializedName("serializationStartTime")
//        private long serializationStartTime;
//        @SerializedName("serializationFinalTime")
//        private long serializationFinalTime;
//        @SerializedName("bytes")
//        private byte[] bytes;
//
//        public long getSerializationStartTime() {
//            return serializationStartTime;
//        }
//
//        public void setSerializationStartTime(long serializationStartTime) {
//            this.serializationStartTime = serializationStartTime;
//        }
//
//        public long getSerializationFinalTime() {
//            return serializationFinalTime;
//        }
//
//        public void setSerializationFinalTime(long serializationFinalTime) {
//            this.serializationFinalTime = serializationFinalTime;
//        }
//
//        public byte[] getBytes() {
//            return bytes;
//        }
//
//        public void setBytes(byte[] bytes) {
//            this.bytes = bytes;
//        }
//    }
}
