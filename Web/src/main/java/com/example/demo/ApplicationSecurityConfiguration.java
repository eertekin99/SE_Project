package com.example.demo;

import com.example.demo.Auth.CustomerUserDetailsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.dao.DaoAuthenticationProvider;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.method.configuration.EnableGlobalMethodSecurity;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.builders.WebSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;
import org.springframework.security.core.authority.mapping.GrantedAuthoritiesMapper;
import org.springframework.security.core.authority.mapping.SimpleAuthorityMapper;
import org.springframework.security.crypto.password.NoOpPasswordEncoder;
import org.springframework.security.web.util.matcher.AntPathRequestMatcher;

@Configuration
@EnableWebSecurity
@EnableGlobalMethodSecurity(prePostEnabled = true)
public class ApplicationSecurityConfiguration extends WebSecurityConfigurerAdapter {
    @Autowired
    private CustomerUserDetailsService customerUserDetailsService;

    @Bean
     DaoAuthenticationProvider authenticationProvider(){
         DaoAuthenticationProvider provider = new DaoAuthenticationProvider();
         provider.setUserDetailsService(customerUserDetailsService);
         provider.setPasswordEncoder(NoOpPasswordEncoder.getInstance());
         return provider;
     }

    @Override
    protected void configure(AuthenticationManagerBuilder auth) throws Exception {
        auth.authenticationProvider(authenticationProvider());
    }
    @Bean
    public GrantedAuthoritiesMapper authoritiesMapper(){
        SimpleAuthorityMapper authorityMapper = new SimpleAuthorityMapper();
        authorityMapper.setConvertToUpperCase(true);
        authorityMapper.setDefaultAuthority("CUSTOMER");
        return authorityMapper;
    }

    @Override
    public void configure(HttpSecurity http) throws Exception {
//         http
//                 .csrf().disable()
//                 .authorizeRequests()
//                 .antMatchers("/Cargo").hasAnyAuthority("CUSTOMER")
//                 .anyRequest().authenticated()
//                 .and()
//                 .formLogin().permitAll()
//                 .and()
//                 .logout().permitAll()
//                 .invalidateHttpSession(true)
//                 .clearAuthentication(true)
//                 .and()
//                 .exceptionHandling().accessDeniedPage("/403");
//        super.configure(web);

        http.authorizeRequests()
//                .antMatchers("/").hasAnyAuthority()
                .antMatchers("/Customer/account").hasAnyAuthority("CUSTOMER")
//                .antMatchers("/delete/**").hasAuthority("ADMIN")
//                .anyRequest().authenticated()
                .and()
                .formLogin().loginPage("/Customer/login").permitAll()
                .defaultSuccessUrl("/Customer/account")
                .and()
                .logout().invalidateHttpSession(true)
                .clearAuthentication(true)
                .logoutRequestMatcher(new AntPathRequestMatcher("/logout"))
                .and()
                .exceptionHandling().accessDeniedPage("/403")
        ;
    }
}
