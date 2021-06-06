package com.example.demo.Auth;

import com.example.demo.Entity.Customer;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;

import java.nio.file.attribute.UserPrincipal;
import java.util.Collection;
import java.util.Collections;

public class CustomerUserPrincipal implements UserDetails {
    Customer customer;

    public CustomerUserPrincipal(Customer customer) {
        super();
        this.customer = customer;
    }

    @Override
    public Collection<? extends GrantedAuthority> getAuthorities() {
        return Collections.singleton(new SimpleGrantedAuthority("CUSTOMER"));
    }

    @Override
    public String getUsername() {
        return customer.getCMobile();
    }

    @Override
    public boolean isAccountNonExpired() {
        return true;
    }

    @Override
    public boolean isAccountNonLocked() {
        return true;
    }

    @Override
    public boolean isCredentialsNonExpired() {
        return true;
    }

    @Override
    public boolean isEnabled() {
        return true;
    }

    @Override
    public String getPassword() {
        return customer.getCMobile();
    }

    public Customer getCustomer() {
        return customer;
    }
}
