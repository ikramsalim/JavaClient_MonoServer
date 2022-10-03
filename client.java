import java.io.*;
import java.net.*;
import java.util.*;

class client1 {
    public static void main(String[] Args) {

        //Console console = System.console();

        try {

            //boolean loop = true;

            //create server socket
            Socket s = new Socket("mono", 8080);

            InputStreamReader isr;
            BufferedReader br;
            PrintStream ps;

            isr = new InputStreamReader(s.getInputStream());
            br = new BufferedReader(isr);
            ps = new PrintStream(s.getOutputStream());

            ps.println("Welcome \n");

            String line = br.readLine();
            while (line != null) {
                System.out.println(line);
                line = br.readLine();
            }

            s.close();

        } catch (Exception E) {
            System.out.println("oops");
            
            
        }



        
    }
}