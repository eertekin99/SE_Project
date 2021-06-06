package com.example.demo.Auth;

import com.example.demo.Entity.Customer;
import com.example.demo.repository.CustomerRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

@Service
public class CustomerUserDetailsService implements UserDetailsService {
   private  CustomerRepository customerRepository;

    public CustomerUserDetailsService(CustomerRepository customerRepository) {
        super();
        this.customerRepository = customerRepository;
    }

    @Override
    public UserDetails loadUserByUsername(String s) throws UsernameNotFoundException {
        Customer customer = customerRepository.findCustomerByCMobile(s);
        if(customer==null){
            throw new UsernameNotFoundException("Wrong username");
        }
        return new CustomerUserPrincipal(customer);
    }
}
