package com.example.demo.Controller;

import com.example.demo.Auth.CustomerUserPrincipal;
import com.example.demo.Entity.Customer;
import com.example.demo.repository.CustomerRepository;
import org.dom4j.rule.Mode;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import java.security.Principal;

@Controller
@RequestMapping("/Customer")
public class CustomerController {
    CustomerRepository customerRepository;
    @Autowired
    public CustomerController(CustomerRepository customerRepository) {
        this.customerRepository = customerRepository;
    }
    @GetMapping(value="/login")
    public String getLoginPage(Model model){
        return "login";
    }

//    @GetMapping(value="/account")
//    public String getAccountPage(Model model){
//        return "account";
//    }
    @GetMapping(value="/account")
    public String getAccount(Authentication authentication, Model model) {
        UserDetails userDetails = (UserDetails) authentication.getPrincipal();
        Customer customer = customerRepository.findCustomerByCMobile(userDetails.getUsername());
        model.addAttribute("customerAccount",customer);
        model.addAttribute("cargosReceived",customer.getCargosReceived());
        model.addAttribute("cargosSent",customer.getCargosSent());
        return "account";
    }
}
