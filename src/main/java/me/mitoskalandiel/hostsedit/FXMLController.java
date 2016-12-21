package me.mitoskalandiel.hostsedit;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import me.mitoskalandiel.jokerlibs.*;

public class FXMLController implements Initializable {

    private final boolean doDebug = true;

    @FXML
    private Label label;

    @FXML
    private void handleButtonAction(ActionEvent event) {
        String pw;
        pw = new String(JokerCrypto.generatePassword(10));
        if (doDebug) {
            System.out.println("You clicked me!");
        }
        label.setText("Hello World! :: " + pw);
    }

    @FXML
    private void handleClose(ActionEvent event) {
        System.exit(0);
    }

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }
}
