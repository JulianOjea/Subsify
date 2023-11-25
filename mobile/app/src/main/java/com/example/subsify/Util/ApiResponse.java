package com.example.subsify.Util;
import java.util.List;

public class ApiResponse<T> {
    private int code;
    private String message;
    private List<T> data;

    public int getCode() {
        return code;
    }

    public String getMessage() {
        return message;
    }

    public List<T> getData() {
        return data;
    }
}
