package org.charles.weilog.domain;

import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.experimental.Accessors;

import javax.persistence.*;
import java.sql.Time;
import java.util.Date;

/**
 * 用户。
 */
@Data
@Accessors(chain = true)
@NoArgsConstructor
@Entity
@Table(name = "users")
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    // 用户名称
    private String username;
    // 用户密码
    private String password;
    // 用户昵称
    private String nickname;
    private String email;
    private String phone;
    private String description;
    private String avatar;
    private Integer role;
    private Boolean status;

    @Temporal(TemporalType.TIMESTAMP)
    private Date registeredTime;
    @Temporal(TemporalType.TIMESTAMP)
    private Date createdTime;
    @Temporal(TemporalType.TIMESTAMP)
    private Date modifiedTime;
}