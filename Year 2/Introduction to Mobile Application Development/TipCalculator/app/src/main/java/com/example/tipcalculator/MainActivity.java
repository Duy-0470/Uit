package com.example.tipcalculator;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.TextView;

import java.text.NumberFormat;

public class MainActivity extends AppCompatActivity {
    private TextView amountTextView;
    private TextView percentLabelTextView;
    private TextView tipTextView;
    private TextView totalTextView;

    private double amount = 0.0;
    private double percent = 0.15;


    private static final NumberFormat numberCurrency = NumberFormat.getCurrencyInstance();
    private static final NumberFormat numberPercent = NumberFormat.getPercentInstance();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        amountTextView = (TextView) findViewById(R.id.amountTextView);
        percentLabelTextView = (TextView) findViewById(R.id.percentLabelTextView);
        tipTextView = (TextView) findViewById(R.id.tipTextView);
        totalTextView = (TextView) findViewById(R.id.totalTextView);
        tipTextView.setText(numberCurrency.format(0));
        totalTextView.setText(numberCurrency.format(0));

        final EditText amountEditText = (EditText) findViewById(R.id.amountEditText);
        amountEditText.addTextChangedListener(amountEditTextWatcher);

        SeekBar percentSeekBar = (SeekBar) findViewById(R.id.percentSeekBar);
        percentSeekBar.setOnSeekBarChangeListener(seekBarListener);
    }

    private void TipCalculator() {
        double tip = amount * percent;
        double total = amount + tip;
        tipTextView.setText(numberCurrency.format(tip));
        totalTextView.setText(numberCurrency.format(total));
    }

    private final TextWatcher amountEditTextWatcher = new TextWatcher() {
        @Override
        public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

        }

        @Override
        public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
            try {
                amount = Double.parseDouble(charSequence.toString()) / 100;
                amountTextView.setText(numberCurrency.format(amount));
            }
            catch (NumberFormatException e) {
                amountTextView.setText("");
                amount = 0.0;
            }
            TipCalculator();
        }

        @Override
        public void afterTextChanged(Editable editable) {

        }
    };

    private final SeekBar.OnSeekBarChangeListener seekBarListener = new SeekBar.OnSeekBarChangeListener() {
        @Override
        public void onProgressChanged(SeekBar seekBar, int progress, boolean b) {
            percent = progress / 100.0;
            percentLabelTextView.setText(numberPercent.format(percent));
            TipCalculator();
        }

        @Override
        public void onStartTrackingTouch(SeekBar seekBar) {

        }

        @Override
        public void onStopTrackingTouch(SeekBar seekBar) {

        }
    };
}